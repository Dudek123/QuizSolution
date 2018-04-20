using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolution.Presenters
{
    public class QS_Presenter
    {
        Models.QS_Model model;
        Views.QS_IView view;
        public QS_Presenter(Models.QS_Model model, Views.QS_IView view)
        {
            this.model = model;
            this.view = view;
        }
    }
}
