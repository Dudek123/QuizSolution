namespace QuizSolution.Controls
{
    partial class Control_QuestionResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_questionText = new System.Windows.Forms.Label();
            this.pictureBox_1 = new System.Windows.Forms.PictureBox();
            this.label_answer1 = new System.Windows.Forms.Label();
            this.label_answer2 = new System.Windows.Forms.Label();
            this.pictureBox_2 = new System.Windows.Forms.PictureBox();
            this.label_Points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_questionText
            // 
            this.label_questionText.AutoSize = true;
            this.label_questionText.Location = new System.Drawing.Point(107, 12);
            this.label_questionText.Name = "label_questionText";
            this.label_questionText.Size = new System.Drawing.Size(73, 13);
            this.label_questionText.TabIndex = 0;
            this.label_questionText.Text = "Question Text";
            this.label_questionText.TextChanged += new System.EventHandler(this.label_questionText_TextChanged);
            // 
            // pictureBox_1
            // 
            this.pictureBox_1.Location = new System.Drawing.Point(16, 32);
            this.pictureBox_1.Name = "pictureBox_1";
            this.pictureBox_1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_1.TabIndex = 1;
            this.pictureBox_1.TabStop = false;
            // 
            // label_answer1
            // 
            this.label_answer1.AutoSize = true;
            this.label_answer1.Location = new System.Drawing.Point(50, 38);
            this.label_answer1.Name = "label_answer1";
            this.label_answer1.Size = new System.Drawing.Size(48, 13);
            this.label_answer1.TabIndex = 2;
            this.label_answer1.Text = "Answer1";
            // 
            // label_answer2
            // 
            this.label_answer2.AutoSize = true;
            this.label_answer2.Location = new System.Drawing.Point(50, 78);
            this.label_answer2.Name = "label_answer2";
            this.label_answer2.Size = new System.Drawing.Size(48, 13);
            this.label_answer2.TabIndex = 4;
            this.label_answer2.Text = "Answer2";
            // 
            // pictureBox_2
            // 
            this.pictureBox_2.Location = new System.Drawing.Point(16, 72);
            this.pictureBox_2.Name = "pictureBox_2";
            this.pictureBox_2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_2.TabIndex = 3;
            this.pictureBox_2.TabStop = false;
            // 
            // label_Points
            // 
            this.label_Points.AutoSize = true;
            this.label_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Points.Location = new System.Drawing.Point(226, 56);
            this.label_Points.Name = "label_Points";
            this.label_Points.Size = new System.Drawing.Size(25, 25);
            this.label_Points.TabIndex = 5;
            this.label_Points.Text = "0";
            // 
            // Control_QuestionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label_Points);
            this.Controls.Add(this.label_answer2);
            this.Controls.Add(this.pictureBox_2);
            this.Controls.Add(this.label_answer1);
            this.Controls.Add(this.pictureBox_1);
            this.Controls.Add(this.label_questionText);
            this.Name = "Control_QuestionResult";
            this.Size = new System.Drawing.Size(297, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_questionText;
        private System.Windows.Forms.PictureBox pictureBox_1;
        private System.Windows.Forms.Label label_answer1;
        private System.Windows.Forms.Label label_answer2;
        private System.Windows.Forms.PictureBox pictureBox_2;
        private System.Windows.Forms.Label label_Points;
    }
}
