using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Models
{
    public class FileModel : INotifyPropertyChanged
    {
        private string? _folderPath;
        private string? _fileName;

        public string FolderPath 
        { 
            get { return _folderPath; }
            set
            {
                _folderPath = value;
                OnPropertyChanged("FolderPath");
            } 
        }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnPropertyChanged("FileName");
            }
        }

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
