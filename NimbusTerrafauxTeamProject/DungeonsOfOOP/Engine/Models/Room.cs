namespace Engine.Models
{
    using System;

    using Common;

    public sealed class Room
    {
        private int addedTrainers;
        private int maxTrainers;
        public Room()
        {
            addedTrainers = 0;
            maxTrainers = Playground.Trainers.Count;
            ContentGenerator();
        }

        public bool IsOpened { get; set; }

        public GameObject GameObj { get; set; }

        private void ContentGenerator()
        {
            switch (RandomGenerator.Return(0, 2))
            {
                case 0:
                    ContentAddFriend();
                    break;
                case 1:
                    ContentAddEnemy();
                    break;
                case 2:
                    ContentAddBox();
                    break;
            }
        }

        private void ContentAddBox()
        {
            bool hasBonus = false;
            switch (RandomGenerator.Return(0, 1))
            {
                case 0:
                    hasBonus = false;
                    break;
                case 1:
                    hasBonus = true;
                    break;
            }

            this.GameObj = new Box(hasBonus);
        }

        private void ContentAddFriend()
        {
            this.GameObj = Playground.RandomCharacter(Playground.Friends); // set random Friend
        }

        private void ContentAddEnemy()
        {
            switch (RandomGenerator.Return(0, 1))
            {
                case 0:
                    this.GameObj = Playground.RandomCharacter(Playground.Fighters);  // Set random Fighter 
                    break;
                case 1:
                    if (addedTrainers++ < maxTrainers)
                    {
                        this.GameObj = Playground.RandomCharacter(Playground.Trainers); // Set random Trainer and then remove it 
                        break;
                    }
                    this.GameObj = Playground.RandomCharacter(Playground.Fighters);
                    break;
            }
        }



    }
}
