namespace Engine.Models
{
    using System.Collections.Generic;

    using Common;
    using Engines;
    using Quiz;

    public class Trainer : Character
    {

        public Trainer()
            : base()
        {

        }

        public Trainer(string name, int intellect)
            : base(name, intellect)
        {
            hitPoints = intellect;
        }

        public Trainer(string name, int intellect = Constants.MaxIntellect, bool hasMoreQuest = true)
            : this()
        {
            this.Name = name;
            this.Intellect = intellect;
            this.HasMoreQuestions = hasMoreQuest;
            this.Questions = new List<Question>();
        }

        #region Props
        public IList<Question> Questions { get; private set; }

        public bool HasMoreQuestions { get; set; }
        #endregion

        public void PopulateQuestionsList()
        {
            int questionsCount = 10;

            for (int i = 0; i < questionsCount; i++)
            {
                int index = RandomGenerator.Return(0, QuizEngine.AllQuestions.Count - 1);
                this.Questions.Add(QuizEngine.AllQuestions[index]);
            }
        }

        //Returns random question and removes it from list
        public Question AskQuestion()
        {
            int index = RandomGenerator.Return(0, this.Questions.Count - 1);
            var question = this.Questions.ExtractQuestion(index);
            this.Questions.Remove(question);
            if (Questions.Count == 0)
            {
                this.HasMoreQuestions = false;
            }
            return question;
        }

        public override void Hit(Character characterToHit, int damage)
        {
            characterToHit.Intellect -= damage;
        }


    }
}
