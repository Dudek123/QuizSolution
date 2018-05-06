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
            this.checkBox_Answer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_Answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Answer.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Answer.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Answer.Location = new System.Drawing.Point(9, 10);
            this.checkBox_Answer.Name = "checkBox_Answer";
            this.checkBox_Answer.Size = new System.Drawing.Size(12, 11);
            this.checkBox_Answer.TabIndex = 0;
            this.checkBox_Answer.UseVisualStyleBackColor = true;
            this.checkBox_Answer.CheckedChanged += new System.EventHandler(this.checkBox_Answer_CheckedChanged);
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Answer.ForeColor = System.Drawing.Color.White;
            this.label_Answer.Location = new System.Drawing.Point(30, 6);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(77, 17);
            this.label_Answer.TabIndex = 1;
            this.label_Answer.Text = "Answer Text";
            // 
            // Control_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.checkBox_Answer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_Answer";
            this.Size = new System.Drawing.Size(330, 30);
            this.Click += new System.EventHandler(this.Control_Answer_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Answer;
        private System.Windows.Forms.Label label_Answer;
    }
}
