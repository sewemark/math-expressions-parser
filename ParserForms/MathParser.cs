using System;
using System.Windows.Forms;

namespace ParserForms
{
    public partial class MathParser : Form
    {
        private Parser parser;
        private float result;
        private bool sentenceValid;

        public MathParser()
        {
            InitializeComponent();
            InitVariables();
        }

        public void InitVariables()
        {
            parser = new Parser();
            result = 0;
            sentenceValid = false;
        }

        private void ParseButtonClick(object sender, EventArgs e)
        {
            try
            {
                SetInitilsUIValues();
                Parse();
                SetValidity();
            }
            catch(InvalidSyntaxException ex)
            {
                failLabel.Text = "Sentence not Valid !";
            }
        }
        
        private void SetInitilsUIValues()
        {
            successLabel.Text = "";
            failLabel.Text = "";
        }

        private void Parse()
        {
            result = 0;
            sentenceValid = parser.Parse(new TokenAnalyzer(sentenceTextBox.Text), ref result);
        }

        private void SetValidity()
        {
            if (sentenceValid)
            {
                successLabel.Text = "Sentence Valid  " + result.ToString();
            }
            else
            {
                failLabel.Text = "Sentence not Valid !";
            }
        }
    }
}
