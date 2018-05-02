using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Classes
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public bool IsRight { get; set; }
        bool isSelected = false;

        public Answer(string ans, bool isRgt)
        {
            AnswerText = ans;
            IsRight = isRgt;
        }
        public Answer() { }

        public void SetSelected(bool sel)
        {
            isSelected = sel;
        }

        public bool GetState()
        {
            return isSelected;
        }

    }
}
