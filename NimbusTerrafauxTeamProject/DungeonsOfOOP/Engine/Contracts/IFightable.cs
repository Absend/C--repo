namespace Engine.Contracts
{
    using Engine.Models;

    public interface IFightable
    {
        void Hit(Character characterToHit, int damage);
    }
}
