using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolution.Controls
{
    public partial class Control_Question : UserControl
    { 
        public Control_Question()
        {
            InitializeComponent();

            for(int i = 0; i < 8; i++)
            {
                Control_Answer newAnswer = new Control_Answer();
                this.Controls.Add(newAnswer);
                newAnswer.CheckBoxCheckedChange += new EventHandler(Answer_CheckBoxCheckedChange);
                newAnswer.Top = 70 + i * 30;
                newAnswer.Left = 30;
                newAnswer.Visible = false;
                answers_controls[i] = newAnswer;
                SelectedAnswers.Add(false);
            }
        }
        public string QuestionText
        {
            get
            {
                return label_questionText.Text.ToString();
            }
            set
            {
                label_questionText.Text = value;
            }

        }

        private List<string> answersText = new List<string>();
        

        public List<string> AnswersText
        {
            get
            {
                return answersText;
            }
            set
            {
                answersText = value;
            }
        }


        private List<bool> selectedAnswers = new List<bool>();

        public List<bool> SelectedAnswers
        {
            get
            {
                return selectedAnswers;
            }
            set
            {
                selectedAnswers = value;
            }
        }


        private Control_Answer[] answers_controls = new Control_Answer[8];

        public void AddAnswer(string answer, int number, bool isSel)
        {
            answers_controls[number].IsSelected = isSel;
            answers_controls[number].AnswerText = answer;
            answers_controls[number].Visible = true;
        }

        private void Answer_CheckBoxCheckedChange(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                if (((Control_Answer)sender).AnswerText == answers_controls[i].AnswerText)
                {
                    a = i;
                }
            }
            SelectedAnswers[a] = ((Control_Answer)sender).IsSelected;
        }

        private void label_questionText_TextChanged(object sender, EventArgs e)
        {
            if(QuestionText != "")
            {
                for (int i = 0; i < AnswersText.Count; i++)
                {
                    AddAnswer(AnswersText[i], i, SelectedAnswers[i]);
                }
                
            }
                
        }
    }
}
