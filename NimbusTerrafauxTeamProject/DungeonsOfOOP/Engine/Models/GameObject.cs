namespace Engine.Models
{
    using Common.Enums;
    using Engine.Common.Structures;

    public abstract class GameObject
    {
        public GameObject()
        {
            this.IsExisting = true;
        }

        public GameObjectType ObjectType { get; set; }

        public Position Position { get; set; }

        public Size Bounds { get; set; }

        public virtual bool IsExisting { get; set; }
    }
}
