namespace Engine.Contracts
{
    using Engine.Models;

    public interface IAbilityChangeable
    {
        void IncreaseAbility(Player player);
        void DecreaseAbility(Player player);
    }
}
