namespace Engine.Engines
{
    using System;

    using Common;
    using Engine.Models;
    
    public static class FightEngine
    {
        private static bool playerTurn = true;

        public static void Start(Player player, Fighter fighter)
        {
           while(player.hitPoints > 0 && fighter.hitPoints > 0)
            {
                switch (playerTurn)
                {
                    case true:
                        PlayerMove(player, fighter);
                        break;
                    case false:
                        FighterMove(fighter, player);
                        break;
                }
            }

            switch (player.hitPoints > 0)
            {
                case true:
                    Console.WriteLine("Winner {0}", player.Name);
                    break;
                case false:
                    Console.WriteLine("Winner {0}", fighter.Name);
                    break;
            }
        }

        private static void PlayerMove(Player player, Fighter fighter)
        {       
            PlayerAttack(player, fighter);
            playerTurn = false;
        }

        private static void FighterMove(Fighter fighter, Player player)
        {
            FighterAttack(fighter, player);
            playerTurn = true;
        }

        private static void PlayerAttack(Player player, Fighter fighter)
        {
            int damage = CalculateDemage(player);
            player.Hit(fighter, damage);
        }

        private static void FighterAttack(Fighter fighter, Player player)
        {
            int damage = CalculateDemage(fighter);
            fighter.Hit(player, damage);
        }

        private static int CalculateDemage(Character character)
        {
            int damage = 0;

            if (character is Fighter)
            {
                damage = RandomGenerator.Return(1, 6);
            }
            else
            {
                damage = (Dice.Play() * 2) + character.Power;
            }
            return damage;
        }

    }
}
