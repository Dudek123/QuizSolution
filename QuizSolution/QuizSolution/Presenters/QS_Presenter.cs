﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizSolution.Classes;

namespace QuizSolution.Presenters
{
    public class QS_Presenter
    {
        #region PRIVATE FIELDS
        Models.QS_Model model;
        Views.QS_IView view;
        #endregion

        #region CONSTRUCTOR
        public QS_Presenter(Models.QS_Model model, Views.QS_IView view)
        {
            this.model = model;
            this.view = view;
            view.LoadQuiz += loadQuiz;
            view.GetQuizName += getQuizName;
            view.GetQuestion += getQuestion;
            view.SaveAnswers += saveAnswers;
            view.CheckQuestionPoints += checkQuestionPoints;
        }
        #endregion

        #region PRIVATE METHODS
        private int checkQuestionPoints(int number)
        {
            return model.CheckQuestionPoints(number);
        }

        private bool saveAnswers(int arg, List<bool> selAns)
        {
            return model.SaveAnswers(arg, selAns);
        }

        private Question getQuestion(int arg)
        {
            return model.GetQuestion(arg);
        }

        private string getQuizName()
        {
            return model.GetQuizName();
        }

        private bool loadQuiz(string arg)
        {
            return model.LoadQuiz(arg);
        }
        #endregion
    }
}
