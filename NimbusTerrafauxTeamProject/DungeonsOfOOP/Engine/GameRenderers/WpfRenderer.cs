using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Engine.Common.Structures;
using Engine.Models;

namespace Engine.GameRenderers
{
    class WpfRenderer : IRenderer
    {
        public Size ObjectSize
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler<KeyDownEventArgs> UIActionHappened;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Draw(params GameObject[] gameObjects)
        {
            throw new NotImplementedException();
        }

        public bool IsInBounds(Position position)
        {
            throw new NotImplementedException();
        }

        public void ShowEndGameScreen(int highscore)
        {
            throw new NotImplementedException();
        }

        private void HandleKeyDown(object sender, KeyEventArgs args)
        {
            var key = args.Key;
            GameCommand command;
            switch (key)
            {
                case Key.Up:
                    command = GameCommand.MoveUp;
                    break;
                case Key.Down:
                    command = GameCommand.MoveDown;
                    break;
                case Key.Left:
                    command = GameCommand.MoveLeft;
                    break;
                case Key.Right:
                    command = GameCommand.MoveRight;
                    break;
                case Key.Enter:
                    command = GameCommand.PlayPause;
                    break;
                default:
                    command = GameCommand.Fire;
                    break;
            }

            this.UIActionHappened(this, new KeyDownEventArgs(command));
        }
    }
}
