using System.Collections.Generic;
using System.Text;

namespace task3
{
    public class Sentence
    {
        private List<Word> words = new List<Word>();

        public Sentence(string sentenceText)
        {
            string[] wordTexts = sentenceText.Split(' ');
            foreach (string wordText in wordTexts)
            {
                words.Add(new Word(wordText));
            }
        }

        public string GetText()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Word word in words)
            {
                sb.Append(word.GetText());
                sb.Append("");
            }
            sb.Append(". ");
            return sb.ToString();
        }
    }
}