using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Classes
{
    public class Answer
    {
        #region PROPERTIES
        public string AnswerText { get; set; }
        public bool IsRight { get; set; }
        #endregion

        #region PRIVATE FIELDS
        bool isSelected = false;
        #endregion

        #region CONSTRUCTORS
        public Answer(string ans, bool isRgt)
        {
            AnswerText = ans;
            IsRight = isRgt;
        }

        public Answer() { }
        #endregion

        #region PUBLIC METHODS
        public void SetSelected(bool sel)
        {
            isSelected = sel;
        }

        public bool GetState()
        {
            return isSelected;
        }
        #endregion
    }
}
