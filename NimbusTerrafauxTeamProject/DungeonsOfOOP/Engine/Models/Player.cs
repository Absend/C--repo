namespace Engine.Models
{
    using System;

    using Contracts;

    public class Player : Character, IMovable
    {
        public Player()
        {

        }

        public Player(string name)
               : base(name)
        {

        }

        public Player(string name, int power, int intellect) 
            : base(name, power, intellect)
        {
            this.hitPoints = 100;
        }

        public override void Hit(Character characterToHit, int damage)
        {
            characterToHit.hitPoints -= damage;
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
