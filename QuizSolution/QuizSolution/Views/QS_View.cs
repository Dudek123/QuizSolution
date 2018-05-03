using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizSolution.Classes;
using QuizSolution.Views;
using QuizSolution.Controls;

namespace QuizSolution
{
    public partial class QS_View : Form, QS_IView
    {
        private int question_number;

        private List<string> answers = new List<string>();

        public event Func<int, List<bool>, bool> SaveAnswers;
        public event Func<int, Question> GetQuestion;
        public event Func<string, bool> LoadQuiz;
        public event Func<string> GetQuizName;
        public event Func<int, int> CheckQuestionPoints;

        public QS_View()
        {
            InitializeComponent();
        }

        public List<string> Answers
        {
            get
            {
                return answers;
            }

            set
            {
                answers = value;
                control_Question_1.AnswersText = value;
            }
        }

        public string Question
        {
            get
            {
                return Question;
            }

            set
            {
                control_Question_1.QuestionText = value;
            }
        }

        public string QuizName
        {
            set
            {
                label_quizName.Text = value;
            }
        }

        public string QuizPath
        {
            get
            {
                return textBox_quizPath.Text.ToString();
            }

            set
            {
                textBox_quizPath.Text = value;
            }
        }
        private List<bool> selectedAnswers = new List<bool>();
        public List<bool> SelectedAnswers
        {
            get
            {
                return control_Question_1.SelectedAnswers;
            }

            set
            {
                control_Question_1.SelectedAnswers = value;
            }
        }

       

        private void button_chooseQuiz_Click(object sender, EventArgs e)
        {
            openFileDialog_loadQuiz.Title = "Choose quiz";
            openFileDialog_loadQuiz.DefaultExt = "xml";
            openFileDialog_loadQuiz.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog_loadQuiz.Filter = "XML Files|*.xml";

            if (openFileDialog_loadQuiz.ShowDialog() == DialogResult.OK)
            {
                QuizPath = openFileDialog_loadQuiz.FileName;
            }
        }

        private void button_loadQuiz_Click(object sender, EventArgs e)
        {
            if (LoadQuiz(QuizPath))
            {
                QuizName = GetQuizName();
                question_number = 0;
                LoadQuestion(question_number);
            }
        }

        private bool LoadQuestion(int number)
        {
            Question q;
            try
            {
                q = GetQuestion(number);
            }
            catch(Exception)
            {
                MessageBox.Show("Brak pytania");
                return false;
            }
            
            
            List<Answer> ans = q.Answers;
            List<string> ansStrings = new List<string>();
            List<bool> ansBools = new List<bool>();
            foreach(Answer a in ans)
            {
                ansStrings.Add(a.AnswerText);
                ansBools.Add(a.GetState());
            }

            SelectedAnswers = ansBools;
            Answers = ansStrings;
            Question = q.QuestionString;
            
            return true;
        }

        private void button_nextQuestion_Click(object sender, EventArgs e)
        {
            /*Console.WriteLine(SelectedAnswers[0]);
            Console.WriteLine(SelectedAnswers[1]);
            Console.WriteLine(SelectedAnswers[2]);*/
            List<bool> temp = SelectedAnswers;
            if (LoadQuestion(question_number + 1))
            {
                SaveAnswers(question_number, temp);
                question_number++;
            }
        }

        private void button_prevQuestion_Click(object sender, EventArgs e)
        {
           /* Console.WriteLine(SelectedAnswers[0]);
            Console.WriteLine(SelectedAnswers[1]);
            Console.WriteLine(SelectedAnswers[2]);*/
            List<bool> temp = SelectedAnswers;
            if (LoadQuestion(question_number - 1))
            {
                SaveAnswers(question_number, temp);
                question_number--;
            }

        }

        private void button_checkQuiz_Click(object sender, EventArgs e)
        {
            if (SaveAnswers(question_number, SelectedAnswers))
            {

                control_Question_1.Visible = false;

                Panel pl = new Panel();
                pl.Location = new Point(12, 100);
                pl.Size = new Size(this.Size.Width - 40, 300);
                pl.AutoScroll = true;
                pl.BackColor = Color.Aquamarine;
                

                List<Question> questions = new List<Question>();

                for(int i = 0; ; i++)
                {
                    try
                    {
                        questions.Add(GetQuestion(i));
                    }
                    catch(Exception)
                    {
                        break;
                    }
                }

                
                Control_QuestionResult[] result_controls = new Control_QuestionResult[questions.Count];

                for(int i = 0; i < questions.Count; i++)
                {
                    Control_QuestionResult qr = new Control_QuestionResult();
                    if (i == 0)
                        qr.Location = new Point(10, 10);
                    else
                        qr.Location = new Point(10, result_controls[i - 1].Location.Y + result_controls[i - 1].Height + 10);

                    List<Answer> ans = questions[i].Answers;
                    List<string> ansStr = new List<string>();
                    foreach(Answer a in ans)
                    {
                        ansStr.Add(a.AnswerText);
                    }
                    List<int> howSel = new List<int>();
                    foreach(Answer xd in ans)
                    {
                        if (xd.GetState() && xd.IsRight)
                            howSel.Add(0);
                        if (xd.GetState() && !xd.IsRight)
                            howSel.Add(1);
                        if((!xd.GetState() && xd.IsRight) || (!xd.GetState() && !xd.IsRight))
                            howSel.Add(3);
                        
                       
                    }

                    qr.HowSelected = howSel;
                    qr.QuestionPoints = CheckQuestionPoints(i);
                    qr.AnswersText = ansStr;
                    qr.QuestionText = questions[i].QuestionString;
                    Console.WriteLine(i.ToString());       
                    result_controls[i] = qr;
                    pl.Controls.Add(qr);
                    
                }
                this.Controls.Add(pl);
                //pl.Controls.Add(result_controls[1]);
                Console.WriteLine(result_controls.Length);
                /*
                foreach(Control_QuestionResult cqr in result_controls)
                {
                    pl.Controls.Add(cqr);
                }*/

                //pl.Controls.Add(result_controls[0]);
                //pl.Controls.Add(result_controls[1]);

                
                /*
                Control_QuestionResult qr = new Control_QuestionResult();
                this.Controls.Add(qr);
                qr.Location = new Point(12, 100);*/



            }
            else
                MessageBox.Show("No loaded quiz");
           
        }

       
    }
}
