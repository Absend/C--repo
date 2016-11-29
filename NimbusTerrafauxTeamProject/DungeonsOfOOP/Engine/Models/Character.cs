namespace Engine.Models
{
    using System;
    using Engine.Contracts;

    public abstract class Character : GameObject, IFightable
    {
        public Character()
        {

        }

        public Character(string name)
        {
            this.Name = name;
        }

        public Character(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }

        public Character(string name, int power, int intellect)
        {
            this.Name = name;
            this.Power = power;
            this.Intellect = intellect;
        }

        public string Name { get; set; }

        public int Power { get; set; }

        public int Intellect { get; set; }

        public int hitPoints { get; set; }

        public abstract void Hit(Character characterToHit, int damage);
    }
}
