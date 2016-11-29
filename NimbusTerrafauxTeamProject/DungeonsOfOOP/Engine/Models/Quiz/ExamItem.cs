namespace Engine.Models.Quiz
{
    using System.Text;
    
    using Common.Exceptions;

    public abstract class ExamItem
    {
        private string itemText;

        public ExamItem()
        {
        }

        public ExamItem(string itemText)
        {
            this.ItemText = itemText;
        }

        public string ItemText
        {
            get
            {
                return this.itemText;
            }
            set
            {
                Validator.ValidateStringIsNotNullOrEmpty(value, "Item Text");
                this.itemText = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.Append(this.ItemText);
            output.AppendLine();
            return output.ToString();
        }
    }
}
