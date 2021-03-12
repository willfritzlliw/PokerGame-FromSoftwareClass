namespace PokerGame
{
    partial class Cards
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
            this.label3 = new System.Windows.Forms.Label();
            this.checkHand = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.dealersCard5 = new System.Windows.Forms.PictureBox();
            this.dealersCard4 = new System.Windows.Forms.PictureBox();
            this.dealersCard3 = new System.Windows.Forms.PictureBox();
            this.dealersCard2 = new System.Windows.Forms.PictureBox();
            this.dealersCard1 = new System.Windows.Forms.PictureBox();
            this.yourCard5 = new System.Windows.Forms.PictureBox();
            this.yourCard4 = new System.Windows.Forms.PictureBox();
            this.yourCard3 = new System.Windows.Forms.PictureBox();
            this.yourCard2 = new System.Windows.Forms.PictureBox();
            this.yourCard1 = new System.Windows.Forms.PictureBox();
            this.txtWinner = new System.Windows.Forms.Label();
            this.showHandEval = new System.Windows.Forms.CheckBox();
            this.BetingAmt = new System.Windows.Forms.TextBox();
            this.Placebet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.WarningLbl = new System.Windows.Forms.Label();
            this.PlayerCash = new System.Windows.Forms.Label();
            this.DealerCash = new System.Windows.Forms.Label();
            this.GameWinner = new System.Windows.Forms.Label();
            this.NewGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "yourHand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(627, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "dealersHand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Click on a card to exchange it for a new one (up to 3)";
            // 
            // checkHand
            // 
            this.checkHand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.checkHand.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHand.Location = new System.Drawing.Point(27, 251);
            this.checkHand.Name = "checkHand";
            this.checkHand.Size = new System.Drawing.Size(180, 33);
            this.checkHand.TabIndex = 15;
            this.checkHand.Text = "Click If Satisfied with Hand";
            this.checkHand.UseVisualStyleBackColor = false;
            this.checkHand.Click += new System.EventHandler(this.checkHand_Click);
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewGame.Enabled = false;
            this.NewGame.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(27, 471);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(180, 33);
            this.NewGame.TabIndex = 17;
            this.NewGame.Text = "Click For New Hand";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Visible = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // dealersCard5
            // 
            this.dealersCard5.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.dealersCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealersCard5.Location = new System.Drawing.Point(1090, 134);
            this.dealersCard5.Name = "dealersCard5";
            this.dealersCard5.Size = new System.Drawing.Size(110, 150);
            this.dealersCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard5.TabIndex = 12;
            this.dealersCard5.TabStop = false;
            // 
            // dealersCard4
            // 
            this.dealersCard4.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.dealersCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealersCard4.Location = new System.Drawing.Point(974, 134);
            this.dealersCard4.Name = "dealersCard4";
            this.dealersCard4.Size = new System.Drawing.Size(110, 150);
            this.dealersCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard4.TabIndex = 11;
            this.dealersCard4.TabStop = false;
            // 
            // dealersCard3
            // 
            this.dealersCard3.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.dealersCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealersCard3.Location = new System.Drawing.Point(858, 134);
            this.dealersCard3.Name = "dealersCard3";
            this.dealersCard3.Size = new System.Drawing.Size(110, 150);
            this.dealersCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard3.TabIndex = 10;
            this.dealersCard3.TabStop = false;
            // 
            // dealersCard2
            // 
            this.dealersCard2.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.dealersCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealersCard2.Location = new System.Drawing.Point(742, 134);
            this.dealersCard2.Name = "dealersCard2";
            this.dealersCard2.Size = new System.Drawing.Size(110, 150);
            this.dealersCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard2.TabIndex = 9;
            this.dealersCard2.TabStop = false;
            // 
            // dealersCard1
            // 
            this.dealersCard1.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.dealersCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealersCard1.Location = new System.Drawing.Point(626, 134);
            this.dealersCard1.Name = "dealersCard1";
            this.dealersCard1.Size = new System.Drawing.Size(110, 150);
            this.dealersCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealersCard1.TabIndex = 8;
            this.dealersCard1.TabStop = false;
            // 
            // yourCard5
            // 
            this.yourCard5.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.yourCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourCard5.Location = new System.Drawing.Point(491, 37);
            this.yourCard5.Name = "yourCard5";
            this.yourCard5.Size = new System.Drawing.Size(110, 150);
            this.yourCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourCard5.TabIndex = 6;
            this.yourCard5.TabStop = false;
            this.yourCard5.Click += new System.EventHandler(this.yourCard5_Click);
            // 
            // yourCard4
            // 
            this.yourCard4.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.yourCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourCard4.Location = new System.Drawing.Point(375, 37);
            this.yourCard4.Name = "yourCard4";
            this.yourCard4.Size = new System.Drawing.Size(110, 150);
            this.yourCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourCard4.TabIndex = 5;
            this.yourCard4.TabStop = false;
            this.yourCard4.Click += new System.EventHandler(this.yourCard4_Click);
            // 
            // yourCard3
            // 
            this.yourCard3.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.yourCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourCard3.Location = new System.Drawing.Point(259, 37);
            this.yourCard3.Name = "yourCard3";
            this.yourCard3.Size = new System.Drawing.Size(110, 150);
            this.yourCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourCard3.TabIndex = 3;
            this.yourCard3.TabStop = false;
            this.yourCard3.Click += new System.EventHandler(this.yourCard3_Click);
            // 
            // yourCard2
            // 
            this.yourCard2.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.yourCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourCard2.Location = new System.Drawing.Point(143, 37);
            this.yourCard2.Name = "yourCard2";
            this.yourCard2.Size = new System.Drawing.Size(110, 150);
            this.yourCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourCard2.TabIndex = 2;
            this.yourCard2.TabStop = false;
            this.yourCard2.Click += new System.EventHandler(this.yourCard2_Click);
            // 
            // yourCard1
            // 
            this.yourCard1.BackgroundImage = global::PokerGame.CardsResource.CardBack;
            this.yourCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yourCard1.Location = new System.Drawing.Point(27, 37);
            this.yourCard1.Name = "yourCard1";
            this.yourCard1.Size = new System.Drawing.Size(110, 150);
            this.yourCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourCard1.TabIndex = 1;
            this.yourCard1.TabStop = false;
            this.yourCard1.Click += new System.EventHandler(this.yourCard1_Click);
            // 
            // txtWinner
            // 
            this.txtWinner.AutoSize = true;
            this.txtWinner.BackColor = System.Drawing.Color.LawnGreen;
            this.txtWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinner.ForeColor = System.Drawing.Color.Crimson;
            this.txtWinner.Location = new System.Drawing.Point(638, 37);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.Size = new System.Drawing.Size(0, 55);
            this.txtWinner.TabIndex = 18;
            // 
            // showHandEval
            // 
            this.showHandEval.AutoSize = true;
            this.showHandEval.BackColor = System.Drawing.Color.Transparent;
            this.showHandEval.Checked = true;
            this.showHandEval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHandEval.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHandEval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showHandEval.Location = new System.Drawing.Point(29, 305);
            this.showHandEval.Name = "showHandEval";
            this.showHandEval.Size = new System.Drawing.Size(138, 21);
            this.showHandEval.TabIndex = 19;
            this.showHandEval.Text = "Show Hand Data";
            this.showHandEval.UseVisualStyleBackColor = false;
            this.showHandEval.CheckedChanged += new System.EventHandler(this.showHandEval_CheckedChanged);
            // 
            // BetingAmt
            // 
            this.BetingAmt.Location = new System.Drawing.Point(27, 367);
            this.BetingAmt.Name = "BetingAmt";
            this.BetingAmt.Size = new System.Drawing.Size(100, 20);
            this.BetingAmt.TabIndex = 20;
            // 
            // Placebet
            // 
            this.Placebet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Placebet.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placebet.Location = new System.Drawing.Point(27, 393);
            this.Placebet.Name = "Placebet";
            this.Placebet.Size = new System.Drawing.Size(106, 30);
            this.Placebet.TabIndex = 24;
            this.Placebet.Text = "Place Bet";
            this.Placebet.UseVisualStyleBackColor = false;
            this.Placebet.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(24, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Enter Amount to bet";
            // 
            // WarningLbl
            // 
            this.WarningLbl.AutoSize = true;
            this.WarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.WarningLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WarningLbl.Location = new System.Drawing.Point(133, 370);
            this.WarningLbl.Name = "WarningLbl";
            this.WarningLbl.Size = new System.Drawing.Size(0, 13);
            this.WarningLbl.TabIndex = 25;
            // 
            // PlayerCash
            // 
            this.PlayerCash.AutoSize = true;
            this.PlayerCash.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerCash.Location = new System.Drawing.Point(481, 21);
            this.PlayerCash.Name = "PlayerCash";
            this.PlayerCash.Size = new System.Drawing.Size(0, 13);
            this.PlayerCash.TabIndex = 26;
            // 
            // DealerCash
            // 
            this.DealerCash.AutoSize = true;
            this.DealerCash.BackColor = System.Drawing.Color.Transparent;
            this.DealerCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DealerCash.Location = new System.Drawing.Point(1115, 118);
            this.DealerCash.Name = "DealerCash";
            this.DealerCash.Size = new System.Drawing.Size(0, 13);
            this.DealerCash.TabIndex = 27;
            // 
            // GameWinner
            // 
            this.GameWinner.AutoSize = true;
            this.GameWinner.BackColor = System.Drawing.Color.LawnGreen;
            this.GameWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameWinner.ForeColor = System.Drawing.Color.Crimson;
            this.GameWinner.Location = new System.Drawing.Point(549, 393);
            this.GameWinner.Name = "GameWinner";
            this.GameWinner.Size = new System.Drawing.Size(0, 55);
            this.GameWinner.TabIndex = 28;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewGameBtn.Enabled = false;
            this.NewGameBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(228, 471);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(180, 33);
            this.NewGameBtn.TabIndex = 29;
            this.NewGameBtn.Text = "Click for new Game";
            this.NewGameBtn.UseVisualStyleBackColor = false;
            this.NewGameBtn.Visible = false;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = global::PokerGame.CardsResource.pokerGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1215, 584);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.GameWinner);
            this.Controls.Add(this.DealerCash);
            this.Controls.Add(this.PlayerCash);
            this.Controls.Add(this.WarningLbl);
            this.Controls.Add(this.Placebet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BetingAmt);
            this.Controls.Add(this.showHandEval);
            this.Controls.Add(this.txtWinner);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.checkHand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dealersCard5);
            this.Controls.Add(this.dealersCard4);
            this.Controls.Add(this.dealersCard3);
            this.Controls.Add(this.dealersCard2);
            this.Controls.Add(this.dealersCard1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yourCard5);
            this.Controls.Add(this.yourCard4);
            this.Controls.Add(this.yourCard3);
            this.Controls.Add(this.yourCard2);
            this.Controls.Add(this.yourCard1);
            this.Name = "Cards";
            this.Text = "Poker by Will";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealersCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yourCard1;
        private System.Windows.Forms.PictureBox yourCard2;
        private System.Windows.Forms.PictureBox yourCard3;
        private System.Windows.Forms.PictureBox yourCard4;
        private System.Windows.Forms.PictureBox yourCard5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dealersCard5;
        private System.Windows.Forms.PictureBox dealersCard4;
        private System.Windows.Forms.PictureBox dealersCard3;
        private System.Windows.Forms.PictureBox dealersCard2;
        private System.Windows.Forms.PictureBox dealersCard1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkHand;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label txtWinner;
        private System.Windows.Forms.CheckBox showHandEval;
        private System.Windows.Forms.TextBox BetingAmt;
        private System.Windows.Forms.Button Placebet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WarningLbl;
        private System.Windows.Forms.Label PlayerCash;
        private System.Windows.Forms.Label DealerCash;
        private System.Windows.Forms.Label GameWinner;
        private System.Windows.Forms.Button NewGameBtn;

    }
}

