namespace QuizSolution
{
    partial class QS_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QS_View));
            this.textBox_quizPath = new System.Windows.Forms.TextBox();
            this.label_load = new System.Windows.Forms.Label();
            this.button_chooseQuiz = new System.Windows.Forms.Button();
            this.openFileDialog_loadQuiz = new System.Windows.Forms.OpenFileDialog();
            this.label_quizName = new System.Windows.Forms.Label();
            this.button_loadQuiz = new System.Windows.Forms.Button();
            this.button_prevQuestion = new System.Windows.Forms.Button();
            this.button_nextQuestion = new System.Windows.Forms.Button();
            this.button_checkQuiz = new System.Windows.Forms.Button();
            this.control_Question_1 = new QuizSolution.Controls.Control_Question();
            this.SuspendLayout();
            // 
            // textBox_quizPath
            // 
            this.textBox_quizPath.Location = new System.Drawing.Point(60, 26);
            this.textBox_quizPath.Name = "textBox_quizPath";
            this.textBox_quizPath.Size = new System.Drawing.Size(241, 20);
            this.textBox_quizPath.TabIndex = 0;
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.Location = new System.Drawing.Point(1, 29);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(53, 13);
            this.label_load.TabIndex = 1;
            this.label_load.Text = "Quiz Path";
            // 
            // button_chooseQuiz
            // 
            this.button_chooseQuiz.Location = new System.Drawing.Point(307, 25);
            this.button_chooseQuiz.Name = "button_chooseQuiz";
            this.button_chooseQuiz.Size = new System.Drawing.Size(22, 23);
            this.button_chooseQuiz.TabIndex = 2;
            this.button_chooseQuiz.Text = ">";
            this.button_chooseQuiz.UseVisualStyleBackColor = true;
            this.button_chooseQuiz.Click += new System.EventHandler(this.button_chooseQuiz_Click);
            // 
            // openFileDialog_loadQuiz
            // 
            this.openFileDialog_loadQuiz.FileName = "openFileDialog1";
            // 
            // label_quizName
            // 
            this.label_quizName.AutoSize = true;
            this.label_quizName.Location = new System.Drawing.Point(141, 7);
            this.label_quizName.Name = "label_quizName";
            this.label_quizName.Size = new System.Drawing.Size(56, 13);
            this.label_quizName.TabIndex = 3;
            this.label_quizName.Text = "QuizName";
            // 
            // button_loadQuiz
            // 
            this.button_loadQuiz.Location = new System.Drawing.Point(335, 26);
            this.button_loadQuiz.Name = "button_loadQuiz";
            this.button_loadQuiz.Size = new System.Drawing.Size(67, 23);
            this.button_loadQuiz.TabIndex = 4;
            this.button_loadQuiz.Text = "Load Quiz";
            this.button_loadQuiz.UseVisualStyleBackColor = true;
            this.button_loadQuiz.Click += new System.EventHandler(this.button_loadQuiz_Click);
            // 
            // button_prevQuestion
            // 
            this.button_prevQuestion.Location = new System.Drawing.Point(12, 71);
            this.button_prevQuestion.Name = "button_prevQuestion";
            this.button_prevQuestion.Size = new System.Drawing.Size(25, 23);
            this.button_prevQuestion.TabIndex = 5;
            this.button_prevQuestion.Text = "<-";
            this.button_prevQuestion.UseVisualStyleBackColor = true;
            this.button_prevQuestion.Click += new System.EventHandler(this.button_prevQuestion_Click);
            // 
            // button_nextQuestion
            // 
            this.button_nextQuestion.Location = new System.Drawing.Point(363, 71);
            this.button_nextQuestion.Name = "button_nextQuestion";
            this.button_nextQuestion.Size = new System.Drawing.Size(25, 23);
            this.button_nextQuestion.TabIndex = 6;
            this.button_nextQuestion.Text = "->";
            this.button_nextQuestion.UseVisualStyleBackColor = true;
            this.button_nextQuestion.Click += new System.EventHandler(this.button_nextQuestion_Click);
            // 
            // button_checkQuiz
            // 
            this.button_checkQuiz.Location = new System.Drawing.Point(296, 449);
            this.button_checkQuiz.Name = "button_checkQuiz";
            this.button_checkQuiz.Size = new System.Drawing.Size(92, 23);
            this.button_checkQuiz.TabIndex = 8;
            this.button_checkQuiz.Text = "Check Quiz";
            this.button_checkQuiz.UseVisualStyleBackColor = true;
            this.button_checkQuiz.Click += new System.EventHandler(this.button_checkQuiz_Click);
            // 
            // control_Question_1
            // 
            this.control_Question_1.AnswersText = ((System.Collections.Generic.List<string>)(resources.GetObject("control_Question_1.AnswersText")));
            this.control_Question_1.Location = new System.Drawing.Point(67, 71);
            this.control_Question_1.Name = "control_Question_1";
            this.control_Question_1.QuestionText = "";
            this.control_Question_1.SelectedAnswers = ((System.Collections.Generic.List<bool>)(resources.GetObject("control_Question_1.SelectedAnswers")));
            this.control_Question_1.Size = new System.Drawing.Size(262, 291);
            this.control_Question_1.TabIndex = 7;
            // 
            // QS_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 494);
            this.Controls.Add(this.button_checkQuiz);
            this.Controls.Add(this.control_Question_1);
            this.Controls.Add(this.button_nextQuestion);
            this.Controls.Add(this.button_prevQuestion);
            this.Controls.Add(this.button_loadQuiz);
            this.Controls.Add(this.label_quizName);
            this.Controls.Add(this.button_chooseQuiz);
            this.Controls.Add(this.label_load);
            this.Controls.Add(this.textBox_quizPath);
            this.Name = "QS_View";
            this.Text = "Quiz Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_quizPath;
        private System.Windows.Forms.Label label_load;
        private System.Windows.Forms.Button button_chooseQuiz;
        private System.Windows.Forms.OpenFileDialog openFileDialog_loadQuiz;
        private System.Windows.Forms.Label label_quizName;
        private System.Windows.Forms.Button button_loadQuiz;
        private System.Windows.Forms.Button button_prevQuestion;
        private System.Windows.Forms.Button button_nextQuestion;
        private Controls.Control_Question control_Question_1;
        private System.Windows.Forms.Button button_checkQuiz;
    }
}

