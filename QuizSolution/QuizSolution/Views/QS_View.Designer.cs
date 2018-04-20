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
            this.textBox_quizPath = new System.Windows.Forms.TextBox();
            this.label_load = new System.Windows.Forms.Label();
            this.button_loadQuiz = new System.Windows.Forms.Button();
            this.openFileDialog_loadQuiz = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_quizPath
            // 
            this.textBox_quizPath.Location = new System.Drawing.Point(62, 6);
            this.textBox_quizPath.Name = "textBox_quizPath";
            this.textBox_quizPath.Size = new System.Drawing.Size(257, 20);
            this.textBox_quizPath.TabIndex = 0;
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.Location = new System.Drawing.Point(3, 9);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(53, 13);
            this.label_load.TabIndex = 1;
            this.label_load.Text = "Load quiz";
            // 
            // button_loadQuiz
            // 
            this.button_loadQuiz.Location = new System.Drawing.Point(327, 4);
            this.button_loadQuiz.Name = "button_loadQuiz";
            this.button_loadQuiz.Size = new System.Drawing.Size(22, 23);
            this.button_loadQuiz.TabIndex = 2;
            this.button_loadQuiz.Text = ">";
            this.button_loadQuiz.UseVisualStyleBackColor = true;
            this.button_loadQuiz.Click += new System.EventHandler(this.button_loadQuiz_Click);
            // 
            // openFileDialog_loadQuiz
            // 
            this.openFileDialog_loadQuiz.FileName = "openFileDialog1";
            // 
            // QS_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 494);
            this.Controls.Add(this.button_loadQuiz);
            this.Controls.Add(this.label_load);
            this.Controls.Add(this.textBox_quizPath);
            this.Name = "QS_View";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_quizPath;
        private System.Windows.Forms.Label label_load;
        private System.Windows.Forms.Button button_loadQuiz;
        private System.Windows.Forms.OpenFileDialog openFileDialog_loadQuiz;
    }
}

