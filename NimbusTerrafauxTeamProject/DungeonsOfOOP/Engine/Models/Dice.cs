namespace Engine.Models
{
    public static class Dice
    {
        public static bool IsStoped { get; set; }
        public static int Value = 0;
        public static int LastValue { get; set; }

        public static int Play()
        {
            while (true)
            {
                if (IsStoped)
                {
                    return LastValue;
                }

                LastValue = Value;
                ++Value;
                if (Value > 6)
                {
                    Value = 1;
                }
                return Value;
            }
        }
    }
}
