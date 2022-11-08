using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Models
{
    public class FiltrationsParamsModel : INotifyPropertyChanged
    {
        private int _startPage;
        private int _endPage;
        private string? _requestString;

        public int StartPage
        {
            get { return _startPage; }
            set { _startPage = value; }
        }
        public int EndtPage
        {
            get { return _endPage; }
            set { _endPage = value; }
        }
        public string RequestString
        {
            get { return _requestString; }
            set { _requestString = value; }
        }


        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
