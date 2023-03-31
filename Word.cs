namespace task3
{
    public class Word
    {
        public string Text
        {
            get; 
            set;
        }

        public Word(string text)
        {
            Text = text;
        }

        public string GetText()
        {
            return Text;
        }
    }
}