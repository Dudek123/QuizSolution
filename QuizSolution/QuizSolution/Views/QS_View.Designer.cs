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
            this.textBox_quizPath.BackColor = System.Drawing.Color.Gray;
            this.textBox_quizPath.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_quizPath.ForeColor = System.Drawing.Color.White;
            this.textBox_quizPath.Location = new System.Drawing.Point(57, 34);
            this.textBox_quizPath.Name = "textBox_quizPath";
            this.textBox_quizPath.Size = new System.Drawing.Size(225, 25);
            this.textBox_quizPath.TabIndex = 0;
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_load.ForeColor = System.Drawing.Color.White;
            this.label_load.Location = new System.Drawing.Point(5, 38);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(50, 17);
            this.label_load.TabIndex = 1;
            this.label_load.Text = "Ścieżka";
            // 
            // button_chooseQuiz
            // 
            this.button_chooseQuiz.BackColor = System.Drawing.Color.Gray;
            this.button_chooseQuiz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_chooseQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chooseQuiz.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_chooseQuiz.ForeColor = System.Drawing.Color.White;
            this.button_chooseQuiz.Location = new System.Drawing.Point(288, 34);
            this.button_chooseQuiz.Name = "button_chooseQuiz";
            this.button_chooseQuiz.Size = new System.Drawing.Size(22, 26);
            this.button_chooseQuiz.TabIndex = 2;
            this.button_chooseQuiz.Text = ">";
            this.button_chooseQuiz.UseVisualStyleBackColor = false;
            this.button_chooseQuiz.Click += new System.EventHandler(this.button_chooseQuiz_Click);
            // 
            // openFileDialog_loadQuiz
            // 
            this.openFileDialog_loadQuiz.FileName = "openFileDialog1";
            // 
            // label_quizName
            // 
            this.label_quizName.AutoSize = true;
            this.label_quizName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_quizName.ForeColor = System.Drawing.Color.White;
            this.label_quizName.Location = new System.Drawing.Point(148, 5);
            this.label_quizName.Name = "label_quizName";
            this.label_quizName.Size = new System.Drawing.Size(126, 26);
            this.label_quizName.TabIndex = 3;
            this.label_quizName.Text = "Nazwa Quizu";
            this.label_quizName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_loadQuiz
            // 
            this.button_loadQuiz.BackColor = System.Drawing.Color.Gray;
            this.button_loadQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_loadQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_loadQuiz.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_loadQuiz.ForeColor = System.Drawing.Color.White;
            this.button_loadQuiz.Location = new System.Drawing.Point(316, 34);
            this.button_loadQuiz.Name = "button_loadQuiz";
            this.button_loadQuiz.Size = new System.Drawing.Size(93, 26);
            this.button_loadQuiz.TabIndex = 4;
            this.button_loadQuiz.Text = "Załaduj quiz";
            this.button_loadQuiz.UseVisualStyleBackColor = false;
            this.button_loadQuiz.Click += new System.EventHandler(this.button_loadQuiz_Click);
            // 
            // button_prevQuestion
            // 
            this.button_prevQuestion.BackColor = System.Drawing.Color.Gray;
            this.button_prevQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prevQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prevQuestion.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_prevQuestion.ForeColor = System.Drawing.Color.White;
            this.button_prevQuestion.Location = new System.Drawing.Point(28, 76);
            this.button_prevQuestion.Name = "button_prevQuestion";
            this.button_prevQuestion.Size = new System.Drawing.Size(174, 32);
            this.button_prevQuestion.TabIndex = 5;
            this.button_prevQuestion.Text = "Poprzednie pytanie";
            this.button_prevQuestion.UseVisualStyleBackColor = false;
            this.button_prevQuestion.Click += new System.EventHandler(this.button_prevQuestion_Click);
            // 
            // button_nextQuestion
            // 
            this.button_nextQuestion.BackColor = System.Drawing.Color.Gray;
            this.button_nextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nextQuestion.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_nextQuestion.ForeColor = System.Drawing.Color.White;
            this.button_nextQuestion.Location = new System.Drawing.Point(214, 76);
            this.button_nextQuestion.Name = "button_nextQuestion";
            this.button_nextQuestion.Size = new System.Drawing.Size(174, 32);
            this.button_nextQuestion.TabIndex = 6;
            this.button_nextQuestion.Text = "Następne pytanie";
            this.button_nextQuestion.UseVisualStyleBackColor = false;
            this.button_nextQuestion.Click += new System.EventHandler(this.button_nextQuestion_Click);
            // 
            // button_checkQuiz
            // 
            this.button_checkQuiz.BackColor = System.Drawing.Color.Gray;
            this.button_checkQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_checkQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkQuiz.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_checkQuiz.ForeColor = System.Drawing.Color.White;
            this.button_checkQuiz.Location = new System.Drawing.Point(28, 464);
            this.button_checkQuiz.Name = "button_checkQuiz";
            this.button_checkQuiz.Size = new System.Drawing.Size(360, 50);
            this.button_checkQuiz.TabIndex = 8;
            this.button_checkQuiz.Text = "SPRAWDŹ QUIZ";
            this.button_checkQuiz.UseVisualStyleBackColor = false;
            this.button_checkQuiz.Click += new System.EventHandler(this.button_checkQuiz_Click);
            // 
            // control_Question_1
            // 
            this.control_Question_1.AnswersText = ((System.Collections.Generic.List<string>)(resources.GetObject("control_Question_1.AnswersText")));
            this.control_Question_1.BackColor = System.Drawing.Color.Gray;
            this.control_Question_1.Location = new System.Drawing.Point(28, 123);
            this.control_Question_1.Name = "control_Question_1";
            this.control_Question_1.QuestionText = "";
            this.control_Question_1.SelectedAnswers = ((System.Collections.Generic.List<bool>)(resources.GetObject("control_Question_1.SelectedAnswers")));
            this.control_Question_1.Size = new System.Drawing.Size(360, 330);
            this.control_Question_1.TabIndex = 7;
            // 
            // QS_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(419, 524);
            this.Controls.Add(this.button_checkQuiz);
            this.Controls.Add(this.control_Question_1);
            this.Controls.Add(this.button_nextQuestion);
            this.Controls.Add(this.button_prevQuestion);
            this.Controls.Add(this.button_loadQuiz);
            this.Controls.Add(this.label_quizName);
            this.Controls.Add(this.button_chooseQuiz);
            this.Controls.Add(this.label_load);
            this.Controls.Add(this.textBox_quizPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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

