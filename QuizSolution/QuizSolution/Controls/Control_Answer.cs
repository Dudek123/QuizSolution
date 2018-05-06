using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolution.Controls
{
    public partial class Control_Answer : UserControl
    {
        public string AnswerText
        {
            get { return label_Answer.Text.ToString(); }
            set { label_Answer.Text = value; }
        }
        public bool IsSelected
        {
            get
            {
                if (checkBox_Answer.Checked == true)
                    return true;
                else
                    return false;
            }
            set
            {
                checkBox_Answer.Checked = value;
            }
        }
        public Control_Answer()
        {
            InitializeComponent();
        }

        public Control_Answer(string arg)
        {
            AnswerText = arg;
        }

        public event EventHandler CheckBoxCheckedChange;

        private void checkBox_Answer_CheckedChanged(object sender, EventArgs e)
        {
            if(this.CheckBoxCheckedChange != null)
            {
                this.CheckBoxCheckedChange(this, e);
            }
        }

        private void Control_Answer_Click(object sender, EventArgs e)
        {
            if (checkBox_Answer.Checked == true)
                checkBox_Answer.Checked = false;
            else
                checkBox_Answer.Checked = true;
        }
    }
}
