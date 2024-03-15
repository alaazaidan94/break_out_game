namespace Project_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTImer = new System.Windows.Forms.Timer(this.components);
            this.groupMessage = new System.Windows.Forms.GroupBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.scorelable = new System.Windows.Forms.Label();
            this.tryAginbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.exitebtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.level_lbl = new System.Windows.Forms.Label();
            this.level_lbl_num = new System.Windows.Forms.Label();
            this.groupMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(700, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(88, 24);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // gameTImer
            // 
            this.gameTImer.Interval = 20;
            this.gameTImer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // groupMessage
            // 
            this.groupMessage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupMessage.Controls.Add(this.startbtn);
            this.groupMessage.Controls.Add(this.scorelable);
            this.groupMessage.Controls.Add(this.tryAginbtn);
            this.groupMessage.Controls.Add(this.nextbtn);
            this.groupMessage.Controls.Add(this.exitebtn);
            this.groupMessage.ForeColor = System.Drawing.Color.Black;
            this.groupMessage.Location = new System.Drawing.Point(281, 120);
            this.groupMessage.Name = "groupMessage";
            this.groupMessage.Size = new System.Drawing.Size(264, 277);
            this.groupMessage.TabIndex = 2;
            this.groupMessage.TabStop = false;
            this.groupMessage.Visible = false;
            this.groupMessage.Enter += new System.EventHandler(this.groupMessage_Enter);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(132, 229);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 5;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Visible = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // scorelable
            // 
            this.scorelable.AutoSize = true;
            this.scorelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelable.ForeColor = System.Drawing.Color.Blue;
            this.scorelable.Location = new System.Drawing.Point(14, 25);
            this.scorelable.Name = "scorelable";
            this.scorelable.Size = new System.Drawing.Size(71, 24);
            this.scorelable.TabIndex = 4;
            this.scorelable.Text = "Score:";
            // 
            // tryAginbtn
            // 
            this.tryAginbtn.Location = new System.Drawing.Point(132, 229);
            this.tryAginbtn.Name = "tryAginbtn";
            this.tryAginbtn.Size = new System.Drawing.Size(75, 23);
            this.tryAginbtn.TabIndex = 2;
            this.tryAginbtn.Text = "Try Agin";
            this.tryAginbtn.UseVisualStyleBackColor = true;
            this.tryAginbtn.Click += new System.EventHandler(this.tryAginbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.Location = new System.Drawing.Point(132, 229);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(75, 23);
            this.nextbtn.TabIndex = 1;
            this.nextbtn.Text = "Next Level";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // exitebtn
            // 
            this.exitebtn.Location = new System.Drawing.Point(17, 229);
            this.exitebtn.Name = "exitebtn";
            this.exitebtn.Size = new System.Drawing.Size(75, 23);
            this.exitebtn.TabIndex = 0;
            this.exitebtn.Text = "Exite";
            this.exitebtn.UseVisualStyleBackColor = true;
            this.exitebtn.Click += new System.EventHandler(this.exitebtn_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.InitialImage = null;
            this.ball.Location = new System.Drawing.Point(377, 297);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 23);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Location = new System.Drawing.Point(345, 494);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 50);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // level_lbl
            // 
            this.level_lbl.AutoSize = true;
            this.level_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_lbl.ForeColor = System.Drawing.Color.White;
            this.level_lbl.Location = new System.Drawing.Point(12, 9);
            this.level_lbl.Name = "level_lbl";
            this.level_lbl.Size = new System.Drawing.Size(66, 24);
            this.level_lbl.TabIndex = 3;
            this.level_lbl.Text = "Level:";
            // 
            // level_lbl_num
            // 
            this.level_lbl_num.AutoSize = true;
            this.level_lbl_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level_lbl_num.ForeColor = System.Drawing.Color.White;
            this.level_lbl_num.Location = new System.Drawing.Point(74, 9);
            this.level_lbl_num.Name = "level_lbl_num";
            this.level_lbl_num.Size = new System.Drawing.Size(21, 24);
            this.level_lbl_num.TabIndex = 4;
            this.level_lbl_num.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.level_lbl_num);
            this.Controls.Add(this.level_lbl);
            this.Controls.Add(this.groupMessage);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.groupMessage.ResumeLayout(false);
            this.groupMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTImer;
        private System.Windows.Forms.GroupBox groupMessage;
        private System.Windows.Forms.Label scorelable;
        private System.Windows.Forms.Button tryAginbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button exitebtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label level_lbl;
        private System.Windows.Forms.Label level_lbl_num;
        private System.Windows.Forms.Button startbtn;
    }
}

