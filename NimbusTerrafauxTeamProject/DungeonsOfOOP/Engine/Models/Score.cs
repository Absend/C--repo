namespace Engine.Models
{
    using Engine.Contracts;

    public sealed class Score : IScore
    {
        public Score(int answeredQuestions = 0, int openedRooms = 0)
        {
            this.AnsweredQuestions = answeredQuestions;
            this.OpenedRooms = openedRooms;
        }

        public int? ScorePoints { get; set; }

        public int AnsweredQuestions { get; set; }

        public int OpenedRooms { get; set; }
    }
}
