namespace Engine.Engines
{
    using System;
    using Engine.Models;
    using Engine.Common;
    using System.Threading;
    public static class FriendMeetingEngine
    {

        public static void Start(Player player, Friend friend)
        {
            switch (friend.Name)
            {
                case "Suzane":
                    SuzaneMeeting(player);
                    break;
                case "Ivet":
                    IvetMeeting(player);
                    break;
            }
        }



        private static void SuzaneMeeting(Player player)
        {
            var dice = RandomGenerator.Return(1, 7);
            Thread.Sleep(250);
            player.hitPoints += Convert.ToInt32((100 - player.hitPoints) * (Constants.FriendHelpCoefficient * dice));
            // Formula : lost hitpoints * (constant coeficient K * Dice value)
        }

        private static void IvetMeeting(Player player)
        {
            var dice = RandomGenerator.Return(1, 7);
            Thread.Sleep(250);
            player.Intellect += Convert.ToInt32((100 - player.Intellect) * (Constants.FriendHelpCoefficient * dice));
            // Formula : lost intellect * (constant coeficient K * Dice value)
        }
    }
}
