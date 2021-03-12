namespace PokerGame
{
    partial class HandEvaluation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerWinnings = new System.Windows.Forms.Label();
            this.CPUwinnings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dealers Hand";
            // 
            // playerWinnings
            // 
            this.playerWinnings.AutoSize = true;
            this.playerWinnings.Location = new System.Drawing.Point(36, 72);
            this.playerWinnings.Name = "playerWinnings";
            this.playerWinnings.Size = new System.Drawing.Size(0, 13);
            this.playerWinnings.TabIndex = 2;
            // 
            // CPUwinnings
            // 
            this.CPUwinnings.AutoSize = true;
            this.CPUwinnings.Location = new System.Drawing.Point(333, 72);
            this.CPUwinnings.Name = "CPUwinnings";
            this.CPUwinnings.Size = new System.Drawing.Size(0, 13);
            this.CPUwinnings.TabIndex = 3;
            // 
            // HandEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(497, 279);
            this.Controls.Add(this.CPUwinnings);
            this.Controls.Add(this.playerWinnings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HandEvaluation";
            this.Text = "Hand Evaluation";
            this.Load += new System.EventHandler(this.HandEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerWinnings;
        private System.Windows.Forms.Label CPUwinnings;

    }
}