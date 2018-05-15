using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Classes
{
    public class Quiz
    {
        #region PROPERTIES
        public List<Question> Questions
        {
            get
            {
                return questions;
            }
            set
            {
                questions = value;
            }
        }

        public string QuizName { get; set; }
        #endregion

        #region PRIVATE FIELDS
        private List<Question> questions = new List<Question>();
        #endregion

        #region CONSTRUCTORS
        public Quiz(string arg)
        {
            QuizName = arg;
        }
        public Quiz() { }
        #endregion

        #region PUBLIC METHODS
        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public string GetName()
        {
            return QuizName;
        }

        public Question GetQuestion(int number)
        {
            return questions[number];
        }

        public void ResetQuestions()
        {
            Questions.Clear();
        }
        #endregion
    }
}
