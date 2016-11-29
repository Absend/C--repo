namespace Engine.GameRenderers
{
    using System;

    public enum GameCommand
    {
        Fire,
        MoveUp,
        MoveDown,
        MoveLeft,
        MoveRight,
        PlayPause
    };

    public class KeyDownEventArgs : EventArgs
    {
        public GameCommand Command { get; set; }

        public KeyDownEventArgs(GameCommand command)
        {
            this.Command = command;
        }
    }
}