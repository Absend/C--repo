namespace Engine.Models
{
    using System;
    using Engine.Contracts;

    public class Fighter : Character
    {
        public Fighter()
        {

        }

        public Fighter(string name, int power) 
            : base(name, power)
        {
            this.hitPoints = 100;
        }

        public override void Hit(Character characterToHit, int damage)
        {
            characterToHit.hitPoints -= damage;
        }
    }
}
