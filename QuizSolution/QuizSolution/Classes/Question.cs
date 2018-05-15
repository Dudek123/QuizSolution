using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Classes
{
    public class Question
    {
        #region PROPERTIES
        public string QuestionString { get; set; }
      
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
        #endregion

        #region PRIVATE FIELDS
        private List<Answer> answers = new List<Answer>();
        #endregion

        #region CONSTRUCTORS
        public Question(string question)
        {
            this.QuestionString = question;
        }

        public Question() { }
        #endregion

        #region PUBLIC METHODS
        public void AddAnswer(Answer ans)
        {
            answers.Add(ans);
        }
        #endregion
    }
}
