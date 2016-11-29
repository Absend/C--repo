namespace Engine.Contracts
{
    public interface IScore
    {
        int? ScorePoints { get; set; }

        int AnsweredQuestions { get; set; }

        int OpenedRooms { get; set; }
    }
}
