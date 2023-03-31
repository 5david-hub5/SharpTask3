﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        private Text text = new Text();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            string sentenceText = sentenceTextBox.Text;
            text.AddSentence(new Sentence(sentenceText));
            sentenceTextBox.Clear();
        }

        private void showTextButton_Click(object sender, EventArgs e)
        {
            textTextBox.Text = text.GetText();
        }

        private void showTitleButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = text.GetTitle();
        }

    }
}