using MarketplaceFactory.Models.DTO;
using OfficeOpenXml;

namespace ExcelController
{
    public class ProductExcelGenerator
    {
        public void AddNewWorksheet(ref ExcelPackage package, string WorksheetName, IEnumerable<BasicDTO> Products)
        {
            var sheet = package.Workbook.Worksheets.Add(WorksheetName);

            sheet.Cells["A1"].Value = "Title";
            sheet.Cells["B1"].Value = "Brand";
            sheet.Cells["C1"].Value = "Id";
            sheet.Cells["D1"].Value = "Feddbacks";
            sheet.Cells["E1"].Value = "Price";

            int rowCounter = 1;

            foreach(var product in Products)
            {
                ++rowCounter;

                sheet.Cells[rowCounter, 1].Value = product.Title;
                sheet.Cells[rowCounter, 2].Value = product.Brand;
                sheet.Cells[rowCounter, 3].Value = product.Id;
                sheet.Cells[rowCounter, 4].Value = product.Feddbacks;
                sheet.Cells[rowCounter, 5].Value = product.Price;
            }

            sheet.Columns.AutoFit();
        }
    }
}