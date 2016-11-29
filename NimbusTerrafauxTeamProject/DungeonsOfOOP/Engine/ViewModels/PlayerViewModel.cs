namespace Engine.ViewModels
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    using Commands;
    using Engine.Models;

    public class PlayerViewModel : BaseViewModel
    {
        private bool playerVisible;
        private Player player;

        //=======================================================

        public PlayerViewModel()
        {
            this.player = new Player();
        }

        //=======================================================

        public bool PlayerVisible
        {
            get
            {
                return this.playerVisible;
            }
            set
            {
                if (this.playerVisible != value)
                {
                    this.playerVisible = value;
                    OnPropertyChanged("PlayerVisible");
                }
            }
        }
    }
}
