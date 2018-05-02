using QuizSolution.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Models
{
    public class QS_Model
    {
        Quiz quiz = new Quiz();
        public QS_Model() { }

        public bool LoadQuiz(string path)
        {
            Answer an1 = new Answer("aa", true);
            Answer an2 = new Answer("bb", false);
            Answer an3 = new Answer("cc", false);
            Answer an4 = new Answer("hahah", true);
            Question q1 = new Question("co to jest?");
            Question q2 = new Question("gdzie to było?");
            q1.AddAnswer(an1);
            q1.AddAnswer(an2);
            q1.AddAnswer(an3);
            q2.AddAnswer(an4);
            q2.AddAnswer(an2);
            q2.AddAnswer(an1);
            quiz.QuizName = "Tytuł";
            quiz.AddQuestion(q1);
            quiz.AddQuestion(q2);
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
