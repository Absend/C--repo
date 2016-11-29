namespace Engine.Models
{
    using System;

    using Contracts;
    using Common;

    public class Box : GameObject, IAbilityChangeable
    {
        public Box(bool hasBonus)
        {
            this.HasBonus = hasBonus;
            SetBonuses(HasBonus);
        }


        public bool HasBonus { get; set; }

        public double DeltaStrength { get; set; }

        public double DeltaIntellect { get; set; }

        private void SetBonuses(bool hasBonus)
        {
            switch (HasBonus)
            {
                case true:
                    DeltaStrength = Constants.BoxBonusCoefficient;
                    DeltaIntellect = Constants.BoxBonusCoefficient;
                    break;
                case false:
                    DeltaStrength = Constants.BoxTrapCoefficient;
                    DeltaIntellect = Constants.BoxTrapCoefficient;
                    break;
            }
        }

        public void IncreaseAbility(Player player)
        {
            player.hitPoints += Convert.ToInt32((100 - player.hitPoints) * DeltaStrength);
            player.Intellect += Convert.ToInt32((100 - player.Intellect) * DeltaIntellect);
        }

        public void DecreaseAbility(Player player)
        {
            player.hitPoints = Convert.ToInt32(player.hitPoints * DeltaStrength);
            player.Intellect = Convert.ToInt32(player.Intellect * DeltaIntellect);
        }
    }
}
