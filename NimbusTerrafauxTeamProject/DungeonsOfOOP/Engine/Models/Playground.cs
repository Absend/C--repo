namespace Engine.Models
{
    using System.Collections.Generic;
    using System.Threading;

    using Common;
    using Common.Structures;

    public sealed class Playground
    {

        public ICollection<Room> Rooms { get; set; }
        public static IList<Character> Trainers { get; set; }
        public static IList<Character> Friends { get; set; }
        public static IList<Character> Fighters { get; set; }
        private Size Size { get; set; }

        public Playground(Size size)
        {
            this.Rooms = new List<Room>();
            this.Size = size;
            InitializatеCharacterCollections();
            GeneratePlayground();
        }
        
        private void GeneratePlayground()
        {
            for (int i = 0; i < Size.Height * Size.Width; i++)
            {
                Rooms.Add(new Room());
                //Thread.Sleep(250); //wtf?
            }
        }

        // Set random character from collections

        public static Character RandomCharacter(IList<Character> characters)
        {
            var index = RandomGenerator.Return(0, 100) % characters.Count;
            var character = characters[index];
            if (character is Trainer)
            {
                characters.Remove(character);
            }
            return character;
        }

        // Maybe later this method will be removed from Playground class

        private static void InitializatеCharacterCollections()
        {
            Trainers = new List<Character>
            {
                new Trainer("Cuki", 100),
                new Trainer("Doncho", 100),
                new Trainer("Marto", 100),
                new Trainer("Koceto", 100),
                new Trainer("Victor", 100),
                new Trainer("Ivan", 100)
            };

            Friends = new List<Character>
            {
                new Friend("Suzane"),
                new Friend("Ivet")
            };

            Fighters = new List<Character>
            {
                new Fighter("Org", 7),
                new Fighter("Zombie", 4),
                new Fighter("God", 21),
                new Fighter("Hero", 12),
                new Fighter("Souger", 9),
                new Fighter("King", 16),
                new Fighter("Ninja", 11),
                new Fighter("Alian", 17),
            };



        }
    }
}
