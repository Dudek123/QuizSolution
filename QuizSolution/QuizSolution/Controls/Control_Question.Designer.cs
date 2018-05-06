
namespace QuizSolution.Controls
{
    partial class Control_Question
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
            this.SuspendLayout();
            // 
            // label_questionText
            // 
            this.label_questionText.AutoSize = true;
            this.label_questionText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_questionText.ForeColor = System.Drawing.Color.White;
            this.label_questionText.Location = new System.Drawing.Point(13, 11);
            this.label_questionText.Name = "label_questionText";
            this.label_questionText.Size = new System.Drawing.Size(114, 22);
            this.label_questionText.TabIndex = 0;
            this.label_questionText.Text = "Question Text";
            this.label_questionText.TextChanged += new System.EventHandler(this.label_questionText_TextChanged);
            // 
            // Control_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.label_questionText);
            this.Name = "Control_Question";
            this.Size = new System.Drawing.Size(360, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_questionText;
    }
}
