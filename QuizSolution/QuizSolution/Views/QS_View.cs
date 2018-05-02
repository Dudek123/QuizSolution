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

        }
    }
}
