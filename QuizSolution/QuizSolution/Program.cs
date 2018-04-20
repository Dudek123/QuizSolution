using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Models.QS_Model model = new Models.QS_Model();
            QS_View view = new QS_View();
            Presenters.QS_Presenter presenter = new Presenters.QS_Presenter(model,view);
            Application.Run(view);
        }
    }
}
