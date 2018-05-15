using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Views
{
    public interface QS_IView
    {
        #region VIEW PROPERTIES
        string QuizPath { get; set; }
        string QuizName { set; }
        string Question { get; set; }
        List<string> Answers { get; set; }
        List<bool> SelectedAnswers { get; set; }
        #endregion

        #region VIEW EVENTS
        event Func<int, List<bool>, bool> SaveAnswers;
        event Func<int, Classes.Question> GetQuestion;
        event Func<string, bool> LoadQuiz;
        event Func<string> GetQuizName;
        event Func<int, int> CheckQuestionPoints;
        #endregion
    }
}
