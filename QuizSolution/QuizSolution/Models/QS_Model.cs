using QuizSolution.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace QuizSolution.Models
{
    public class QS_Model
    {
        Quiz quiz = new Quiz();
        public QS_Model() { }

        public bool LoadQuiz(string path)
        {
            quiz.ResetQuestions();
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(path);
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Brak wybranego quizu");
                return false;
            }
            
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator questions = navigator.Select("/Quiz/Question");
            XPathNavigator QuizName = navigator.SelectSingleNode("/Quiz/QuizName");
            quiz.QuizName = QuizName.Value;
            
            foreach(XPathNavigator q in questions)
            {
                XPathNavigator nav = q.SelectSingleNode("QuestionContent");
                Question quest = new Question(nav.Value); 

                XPathNodeIterator answers = q.Select("Answer");

                foreach(XPathNavigator a in answers)
                {
                    XPathNavigator nav2 = a.SelectSingleNode("AnswerContent");
                    XPathNavigator nav3 = a.SelectSingleNode("IsRight");

                    bool isR;
                    if (nav3.Value == "True")
                        isR = true;
                    else
                        isR = false;
                    Answer an = new Answer(nav2.Value, isR);
                    quest.AddAnswer(an);
                }
                quiz.AddQuestion(quest);

            }
            return true;
        }

        public string GetQuizName()
        {
            return quiz.QuizName;
        }

        public Question GetQuestion(int number)
        {
            return quiz.GetQuestion(number);
        }

        public bool SaveAnswers(int questNum, List<bool> selAns)
        {
            try
            {
                Question q = GetQuestion(questNum);

                for (int i = 0; i < selAns.Count; i++)
                {
                    q.Answers[i].SetSelected(selAns[i]);
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
            
        }

        public int CheckQuestionPoints(int number)
        {
            int ptsForQuestion = 0;
            Question q = quiz.GetQuestion(number);
            
            List<Answer> ans = q.Answers;
            foreach(Answer a in ans)
            {
                if (a.IsRight == true && a.GetState() == true)
                    ptsForQuestion = 1;
                if (a.IsRight == false && a.GetState() == false) { }
                if ((a.IsRight == true && a.GetState() == false) || (a.IsRight == false && a.GetState() == true))
                {
                    ptsForQuestion = 0;
                    break;
                }
 
            }
                        
            return ptsForQuestion;
        }

       
    }
}
