namespace Engine.Engines
{
    using Engine.Models;
    public static class BoxOpenEngine
    {
        public static void Start(Player player, Box box)
        {
            switch (box.HasBonus)
            {
                case true:
                    AddBonusToPlayer(player, box);
                    break;
                case false:
                    DecreaseAbilitesFromTrap(player, box);
                    break;
            }
        }

        private static void AddBonusToPlayer(Player player, Box box)
        {
            box.IncreaseAbility(player);
        }

        private static void DecreaseAbilitesFromTrap(Player player, Box box)
        {
            box.DecreaseAbility(player);
        }
    }
}
