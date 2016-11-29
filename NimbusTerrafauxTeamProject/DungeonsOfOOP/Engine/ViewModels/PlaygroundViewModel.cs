namespace Engine.ViewModels
{
    public class PlaygroundViewModel : BaseViewModel
    {
        private bool playgroundVisible;
        private bool startVisible;

        public bool PlaygroundVisible
        {
            get { return this.playgroundVisible; }
            set
            {
                if (this.playgroundVisible != value)
                {
                    this.playgroundVisible = value;
                }
                OnPropertyChanged("PlaygroundVisible");
            }
        }

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
                }
                OnPropertyChanged("StartVisible");
            }
        }
    }
}
