namespace QuizSolution.Controls
{
    partial class Control_Answer
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
            this.checkBox_Answer = new System.Windows.Forms.CheckBox();
            this.label_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_Answer
            // 
            this.checkBox_Answer.AutoSize = true;
            this.checkBox_Answer.Location = new System.Drawing.Point(3, 3);
            this.checkBox_Answer.Name = "checkBox_Answer";
            this.checkBox_Answer.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Answer.TabIndex = 0;
            this.checkBox_Answer.UseVisualStyleBackColor = true;
            this.checkBox_Answer.CheckedChanged += new System.EventHandler(this.checkBox_Answer_CheckedChanged);
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Location = new System.Drawing.Point(24, 3);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(66, 13);
            this.label_Answer.TabIndex = 1;
            this.label_Answer.Text = "Answer Text";
            // 
            // Control_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.checkBox_Answer);
            this.Name = "Control_Answer";
            this.Size = new System.Drawing.Size(248, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Answer;
        private System.Windows.Forms.Label label_Answer;
    }
}
