using System.ComponentModel;
namespace WindowsAppCsharp.ViewModel
{
    public class PessoaViewModel: INotifyPropertyChanged
    {
        private int _id;
        private string _nome;

        public int Id {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Id"));
                }
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (_nome != value)
                {
                    _nome = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Nome"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
