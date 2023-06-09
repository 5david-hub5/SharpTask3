﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace task3
{
    public class Text
        {
            private List<Sentence> sentences = new List<Sentence>();
            public string Title { get; set; }
    
            public void AddSentence(Sentence sentence)
            {
                sentences.Add(sentence);
            }
    
            public string GetText()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Sentence sentence in sentences)
                {
                    sb.Append(sentence.GetText());
                }
                return sb.ToString();
            }
    
            public string GetTitle()
            {
                if (!string.IsNullOrEmpty(Title))
                {
                    return Title;
                }
                
                string[] lines = GetText().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line) && line == line.ToUpper())
                    {
                        Title = line;
                        break;
                    }
                }
                
                return Title;
            }
        }
}