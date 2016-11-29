namespace Engine.Models.Quiz
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Common.Exceptions;

    public class Question : ExamItem
    {
        private IDictionary<Answer, bool> answers;

        public Question() : base()
        {
        }

        public Question(string itemText, IDictionary<Answer, bool> answers) : base(itemText)
        {
            this.Answers = answers;
        }

        public IDictionary<Answer, bool> Answers
        {
            get
            {
                return new Dictionary<Answer, bool>(this.answers);
            }
            private set
            {
                Validator.ValidateIsNotNull(value, "Answers");
                foreach (var answer in value)
                {
                    Validator.ValidateIsNotNull(answer, "Answer key value pair");
                    Validator.ValidateIsNotNull(answer.Key, "Answer");
                }

                this.answers = value;
            }
        }

        public bool CheckAnswer(int answer)
        {
            Validator.ValidateIntIsInRange(answer, 1, this.Answers.Count, "Answer");

            int index = answer - 1;

            return this.Answers.Values.ElementAt(index);
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append(base.ToString());
            for (int i = 0; i < this.Answers.Count; i++)
            {
                output.Append($"{i + 1}:\t");
                output.Append(Answers.Keys.ElementAt(i));
            }

            return output.ToString();
        }
    }
}
