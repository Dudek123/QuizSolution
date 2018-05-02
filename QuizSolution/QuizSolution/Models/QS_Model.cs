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
            document.Load(path);
            XPathNavigator navigator = document.CreateNavigator();
            XPathNodeIterator questions = navigator.Select("/Quiz/Question");
            XPathNavigator QuizName = navigator.SelectSingleNode("/Quiz/QuizName");
            
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
            Question q = GetQuestion(questNum);
            for (int i = 0; i < selAns.Count; i++)
            {
                q.Answers[i].SetSelected(selAns[i]);
            }
            return true;
        }

       
    }
}
