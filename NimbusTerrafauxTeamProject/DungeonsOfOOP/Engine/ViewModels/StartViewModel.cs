using Engine.Commands;
using System.Windows.Input;

namespace Engine.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        private bool startVisible = true;
        private string playerName;
        private ICommand addName;

        public bool StartVisible
        {
            get
            {
                return this.startVisible;
            }
            set
            {
                if (this.startVisible != value)
                {
                    this.startVisible = value;
                    OnPropertyChanged("StartVisible");
                }
            }
        }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }
            set
            {
                this.playerName = value;
                OnPropertyChanged("PlayerName");
            }
        }
        
        public ICommand AddName
        {
            get
            {
                if (this.addName == null)
                {
                    this.addName = new RelayCommand(this.HandleAddName);
                }
                return this.addName;
            }
        }

        private void HandleAddName(object obj)
        {
            this.StartVisible = false;
        }
    }
}
