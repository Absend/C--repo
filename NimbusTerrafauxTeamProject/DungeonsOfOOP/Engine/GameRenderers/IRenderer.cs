namespace Engine.GameRenderers
{
    using Common.Structures;
    using Models;

    public interface IRenderer
    {
        Size ObjectSize { get; }

        void Clear();
        void Draw(params GameObject[] gameObjects);

        bool IsInBounds(Position position);

        void ShowEndGameScreen(int highscore);
    }
}
