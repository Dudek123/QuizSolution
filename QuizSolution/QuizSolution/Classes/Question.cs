using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Classes
{
    public class Question
    {
        public string QuestionString { get; set; }
        private List<Answer> answers = new List<Answer>();
        public List<Answer> Answers
        {
            get
            {
                return answers;
            }
            set
            {
                answers = value;
            }
        }

        public Question(string question)
        {
            this.QuestionString = question;
        }
        public Question() { }

        public void AddAnswer(Answer ans)
        {
            answers.Add(ans);
        }

      
    }
}
