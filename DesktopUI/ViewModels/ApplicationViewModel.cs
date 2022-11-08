using DesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {

        private FileModel _fileModel;
        
        public ObservableCollection<FileModel> File { get; set; }

        public ApplicationViewModel()
        {
            File = new ObservableCollection<FileModel> { 
                new FileModel 
                { 
                    FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), 
                    FileName = "Результат парсинга" 
                } 
            };
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
