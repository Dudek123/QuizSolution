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
    public partial class Control_QuestionResult : UserControl
    {
        public Control_QuestionResult()
        {
            InitializeComponent();
        }

        public string QuestionText
        {
            set
            {
                label_questionText.Text = value;
            }
        }

        public int QuestionPoints
        {
            set
            {
                label_Points.Text = value.ToString();
            }
        }
        private List<string> answersText = new List<string>();
        public List<string> AnswersText
        {
            get
            {
                return answersText;
            }
            set
            {
                answersText = value;
            }
        }
        private List<int> howSelected = new List<int>();
        public List<int> HowSelected
        {
            get
            {
                return howSelected;
            }
            set
            {
                howSelected = value;
            }
        }

        private void label_questionText_TextChanged(object sender, EventArgs e)
        {
            foreach(int a in HowSelected)
            {
                Console.WriteLine(a.ToString());
            }
            if(AnswersText.Count > 2)
            {
                for(int i = 0; i < AnswersText.Count - 2; i++)
                {
                    PictureBox pb = new PictureBox();
                    this.Controls.Add(pb);
                    pb.Location = new Point(16, 112 + i * 40);
                    pb.Size = new Size(25, 25);
                    if (HowSelected[i + 2] == 0)
                        pb.Image = Properties.Resources.correct;
                    if (HowSelected[i + 2] == 1)
                        pb.Image = Properties.Resources.wrong;


                    Label lb = new Label();
                    lb.Location = new Point(50, pb.Location.Y + 6);
                    lb.Text = AnswersText[i + 2];
                    lb.Font = new Font("Palatino Linotype", 9);
                    lb.ForeColor = Color.White;
                    this.Controls.Add(lb);

                    this.Size = new Size(this.Size.Width, this.Size.Height + 40);
                }
                
                if(HowSelected[0] == 0)
                    pictureBox_1.Image = Properties.Resources.correct;
                if (HowSelected[0] == 1)
                    pictureBox_1.Image = Properties.Resources.wrong;
                if (HowSelected[1] == 0)
                    pictureBox_2.Image = Properties.Resources.correct;
                if (HowSelected[1] == 1)
                    pictureBox_2.Image = Properties.Resources.wrong;

                //pictureBox_1.Image = Image.FromFile(@"C:\Users\Bożena\Source\Repos\QuizSolution\QuizSolution\QuizSolution\unchecked.png");
                //pictureBox_2.Image = Image.FromFile(@"C:\Users\Bożena\Source\Repos\QuizSolution\QuizSolution\QuizSolution\unchecked.png");

                label_answer1.Text = AnswersText[0];
                label_answer2.Text = AnswersText[1];


            }
        }
    }
}
