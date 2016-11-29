namespace Engine.Common.Structures
{
    public struct Move
    {
        public Move(Position from, Position to)
            : this()
        {
            this.From = from;
            this.To = to;
        }

        private Position From { get; set; }

        private Position To { get; set; }
    }
}
