using RequestBuilder;
using RequestBuilder.Builders;
using RequestBuilder.Contracts;
using RequestBuilder.RequestProducts;
using MarketplaceFactory;
using MarketplaceFactory.Marketplaces;
using MarketplaceFactory.Models.DTO;
using ExcelController;
using OfficeOpenXml;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyStrings = File.ReadAllLines("Keys.txt");

            Console.WriteLine("Ввод поисковых запросов:");

            int i = 0;
            foreach (string key in keyStrings)
            {
                ++i;

                Console.WriteLine("  " + i + ". " + key);
            }

            Console.WriteLine();

            WildberriesRequestBuilder builder = new WildberriesRequestBuilder();

            Console.WriteLine("Выполнение поисковых запросов");
            string url;
            i = 0;
            IEnumerable<BasicDTO> result;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var package = new ExcelPackage(new FileInfo("MyWorkbook.xlsx"));

            ProductExcelGenerator generator = new ProductExcelGenerator();
            foreach (string key in keyStrings)
            {
                ++i;

                Console.WriteLine("  "+i+". Запрос к серверу по запросу "+ "\"" +key+ "\"");

                url =
                builder
                    .AddBaseUrl(@"https://search.wb.ru/exactmatch/sng/common/v4/search?")
                    .AddBasePrefix(@"__tmp=by&appType=1&couponsGeo=12,7,3,21&curr=&dest=12358386,12358403,-70563,-8139704&emp=0&lang=ru&locale=by&pricemarginCoeff=1&query=игрушки&reg=0&regions=80,83,4,33,70,82,69,68,86,30,40,48,1,22,66,31&resultset=catalog&sort=popular&spp=0&suppressSpellcheck=false&page=1")
                    .AddPageNumber("1")
                    .AddNameFilter(key)
                    .GetUrl();

                result = new WildberriesController().GetResponceAsync(url).Result;

                Console.WriteLine("  Запись в таблицу...");

                generator.AddNewWorksheet(ref package, key, result);
            }

            Console.WriteLine("Вывод сформированной таблицы");

            File.WriteAllBytes(package.File.Name, package.GetAsByteArray());

            Console.WriteLine("Работа программы завершена");
            

            Console.ReadLine();
        }
    }
}


