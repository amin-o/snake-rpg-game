namespace Snake
{
    partial class SnakeRPG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeRPG));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LevelBar = new System.Windows.Forms.ProgressBar();
            this.labelXP = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lvlCounter = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.movementSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combatLog = new System.Windows.Forms.TextBox();
            this.combatLogText = new System.Windows.Forms.Label();
            this.frenzyEffectImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrenzyLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.focusCounter = new System.Windows.Forms.Label();
            this.focusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.headachelbl = new System.Windows.Forms.Label();
            this.headachePic = new System.Windows.Forms.PictureBox();
            this.overfedlbl = new System.Windows.Forms.Label();
            this.overfedPic = new System.Windows.Forms.PictureBox();
            this.wraithformX = new System.Windows.Forms.Label();
            this.wraithformimage = new System.Windows.Forms.PictureBox();
            this.WraithformPointsCounter = new System.Windows.Forms.Label();
            this.wraithformlabel = new System.Windows.Forms.Label();
            this.Wraithtimer = new System.Windows.Forms.Label();
            this.wraithformACTIVE = new System.Windows.Forms.PictureBox();
            this.MutedLbl = new System.Windows.Forms.Label();
            this.mutedPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frenzyEffectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headachePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overfedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wraithformimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wraithformACTIVE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Transparent;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCanvas.Location = new System.Drawing.Point(16, 100);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1175, 549);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.White;
            this.ScoreText.Location = new System.Drawing.Point(1199, 256);
            this.ScoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(100, 32);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1293, 197);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(202, 45);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "9999999";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(67, 208);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(521, 91);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1209, 183);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LevelBar
            // 
            this.LevelBar.ForeColor = System.Drawing.Color.Red;
            this.LevelBar.Location = new System.Drawing.Point(16, 52);
            this.LevelBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LevelBar.MarqueeAnimationSpeed = 10;
            this.LevelBar.Maximum = 50;
            this.LevelBar.Name = "LevelBar";
            this.LevelBar.Size = new System.Drawing.Size(1176, 41);
            this.LevelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LevelBar.TabIndex = 6;
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.BackColor = System.Drawing.Color.Transparent;
            this.labelXP.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelXP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelXP.Location = new System.Drawing.Point(471, 6);
            this.labelXP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(316, 44);
            this.labelXP.TabIndex = 7;
            this.labelXP.Text = "[Experience Bar]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1209, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lvlCounter
            // 
            this.lvlCounter.AutoSize = true;
            this.lvlCounter.BackColor = System.Drawing.Color.Transparent;
            this.lvlCounter.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCounter.ForeColor = System.Drawing.Color.White;
            this.lvlCounter.Location = new System.Drawing.Point(1293, 39);
            this.lvlCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlCounter.Name = "lvlCounter";
            this.lvlCounter.Size = new System.Drawing.Size(75, 73);
            this.lvlCounter.TabIndex = 9;
            this.lvlCounter.Text = "1";
            // 
            // levelText
            // 
            this.levelText.AutoSize = true;
            this.levelText.BackColor = System.Drawing.Color.Transparent;
            this.levelText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelText.ForeColor = System.Drawing.Color.White;
            this.levelText.Location = new System.Drawing.Point(1199, 113);
            this.levelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(95, 32);
            this.levelText.TabIndex = 10;
            this.levelText.Text = "Level";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(39, 657);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // movementSpeed
            // 
            this.movementSpeed.AutoSize = true;
            this.movementSpeed.BackColor = System.Drawing.Color.Transparent;
            this.movementSpeed.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movementSpeed.ForeColor = System.Drawing.Color.SteelBlue;
            this.movementSpeed.Location = new System.Drawing.Point(121, 671);
            this.movementSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movementSpeed.Name = "movementSpeed";
            this.movementSpeed.Size = new System.Drawing.Size(0, 41);
            this.movementSpeed.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(16, 730);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Speed";
            // 
            // combatLog
            // 
            this.combatLog.BackColor = System.Drawing.Color.Black;
            this.combatLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.combatLog.CausesValidation = false;
            this.combatLog.Enabled = false;
            this.combatLog.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLog.ForeColor = System.Drawing.Color.Yellow;
            this.combatLog.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.combatLog.Location = new System.Drawing.Point(1209, 364);
            this.combatLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combatLog.Multiline = true;
            this.combatLog.Name = "combatLog";
            this.combatLog.ReadOnly = true;
            this.combatLog.Size = new System.Drawing.Size(277, 425);
            this.combatLog.TabIndex = 14;
            // 
            // combatLogText
            // 
            this.combatLogText.AutoSize = true;
            this.combatLogText.BackColor = System.Drawing.Color.Transparent;
            this.combatLogText.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatLogText.ForeColor = System.Drawing.Color.White;
            this.combatLogText.Location = new System.Drawing.Point(1297, 321);
            this.combatLogText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.combatLogText.Name = "combatLogText";
            this.combatLogText.Size = new System.Drawing.Size(87, 41);
            this.combatLogText.TabIndex = 15;
            this.combatLogText.Text = "Log";
            // 
            // frenzyEffectImage
            // 
            this.frenzyEffectImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frenzyEffectImage.Enabled = false;
            this.frenzyEffectImage.Image = ((System.Drawing.Image)(resources.GetObject("frenzyEffectImage.Image")));
            this.frenzyEffectImage.Location = new System.Drawing.Point(856, 657);
            this.frenzyEffectImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frenzyEffectImage.Name = "frenzyEffectImage";
            this.frenzyEffectImage.Size = new System.Drawing.Size(53, 49);
            this.frenzyEffectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.frenzyEffectImage.TabIndex = 16;
            this.frenzyEffectImage.TabStop = false;
            this.frenzyEffectImage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(751, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 41);
            this.label1.TabIndex = 17;
            // 
            // FrenzyLabel
            // 
            this.FrenzyLabel.AutoSize = true;
            this.FrenzyLabel.BackColor = System.Drawing.Color.Transparent;
            this.FrenzyLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrenzyLabel.ForeColor = System.Drawing.Color.Red;
            this.FrenzyLabel.Location = new System.Drawing.Point(831, 710);
            this.FrenzyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrenzyLabel.Name = "FrenzyLabel";
            this.FrenzyLabel.Size = new System.Drawing.Size(95, 25);
            this.FrenzyLabel.TabIndex = 18;
            this.FrenzyLabel.Text = "Frenzy!";
            this.FrenzyLabel.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(221, 657);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // focusCounter
            // 
            this.focusCounter.AutoSize = true;
            this.focusCounter.BackColor = System.Drawing.Color.Transparent;
            this.focusCounter.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusCounter.ForeColor = System.Drawing.Color.Turquoise;
            this.focusCounter.Location = new System.Drawing.Point(304, 671);
            this.focusCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focusCounter.Name = "focusCounter";
            this.focusCounter.Size = new System.Drawing.Size(0, 41);
            this.focusCounter.TabIndex = 20;
            // 
            // focusLabel
            // 
            this.focusLabel.AutoSize = true;
            this.focusLabel.BackColor = System.Drawing.Color.Transparent;
            this.focusLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focusLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.focusLabel.Location = new System.Drawing.Point(199, 730);
            this.focusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.focusLabel.Name = "focusLabel";
            this.focusLabel.Size = new System.Drawing.Size(113, 36);
            this.focusLabel.TabIndex = 19;
            this.focusLabel.Text = "Focus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(231, 766);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "[Z]";
            // 
            // headachelbl
            // 
            this.headachelbl.AutoSize = true;
            this.headachelbl.BackColor = System.Drawing.Color.Transparent;
            this.headachelbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headachelbl.ForeColor = System.Drawing.Color.Red;
            this.headachelbl.Location = new System.Drawing.Point(955, 710);
            this.headachelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headachelbl.Name = "headachelbl";
            this.headachelbl.Size = new System.Drawing.Size(81, 25);
            this.headachelbl.TabIndex = 24;
            this.headachelbl.Text = "Dizzy!";
            this.headachelbl.Visible = false;
            // 
            // headachePic
            // 
            this.headachePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headachePic.Enabled = false;
            this.headachePic.Image = ((System.Drawing.Image)(resources.GetObject("headachePic.Image")));
            this.headachePic.Location = new System.Drawing.Point(967, 657);
            this.headachePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headachePic.Name = "headachePic";
            this.headachePic.Size = new System.Drawing.Size(53, 49);
            this.headachePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.headachePic.TabIndex = 23;
            this.headachePic.TabStop = false;
            this.headachePic.Visible = false;
            // 
            // overfedlbl
            // 
            this.overfedlbl.AutoSize = true;
            this.overfedlbl.BackColor = System.Drawing.Color.Transparent;
            this.overfedlbl.CausesValidation = false;
            this.overfedlbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overfedlbl.ForeColor = System.Drawing.Color.Red;
            this.overfedlbl.Location = new System.Drawing.Point(1056, 710);
            this.overfedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.overfedlbl.Name = "overfedlbl";
            this.overfedlbl.Size = new System.Drawing.Size(108, 25);
            this.overfedlbl.TabIndex = 26;
            this.overfedlbl.Text = "Overfed!";
            this.overfedlbl.Visible = false;
            // 
            // overfedPic
            // 
            this.overfedPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overfedPic.Enabled = false;
            this.overfedPic.Image = ((System.Drawing.Image)(resources.GetObject("overfedPic.Image")));
            this.overfedPic.Location = new System.Drawing.Point(1088, 657);
            this.overfedPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overfedPic.Name = "overfedPic";
            this.overfedPic.Size = new System.Drawing.Size(53, 49);
            this.overfedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.overfedPic.TabIndex = 25;
            this.overfedPic.TabStop = false;
            this.overfedPic.Visible = false;
            // 
            // wraithformX
            // 
            this.wraithformX.AutoSize = true;
            this.wraithformX.BackColor = System.Drawing.Color.Transparent;
            this.wraithformX.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wraithformX.ForeColor = System.Drawing.Color.DarkOrchid;
            this.wraithformX.Location = new System.Drawing.Point(393, 766);
            this.wraithformX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wraithformX.Name = "wraithformX";
            this.wraithformX.Size = new System.Drawing.Size(57, 29);
            this.wraithformX.TabIndex = 31;
            this.wraithformX.Text = "[X]";
            // 
            // wraithformimage
            // 
            this.wraithformimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wraithformimage.Enabled = false;
            this.wraithformimage.Image = ((System.Drawing.Image)(resources.GetObject("wraithformimage.Image")));
            this.wraithformimage.Location = new System.Drawing.Point(385, 657);
            this.wraithformimage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wraithformimage.Name = "wraithformimage";
            this.wraithformimage.Size = new System.Drawing.Size(58, 58);
            this.wraithformimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wraithformimage.TabIndex = 30;
            this.wraithformimage.TabStop = false;
            // 
            // WraithformPointsCounter
            // 
            this.WraithformPointsCounter.AutoSize = true;
            this.WraithformPointsCounter.BackColor = System.Drawing.Color.Transparent;
            this.WraithformPointsCounter.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WraithformPointsCounter.ForeColor = System.Drawing.Color.Turquoise;
            this.WraithformPointsCounter.Location = new System.Drawing.Point(468, 671);
            this.WraithformPointsCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WraithformPointsCounter.Name = "WraithformPointsCounter";
            this.WraithformPointsCounter.Size = new System.Drawing.Size(0, 41);
            this.WraithformPointsCounter.TabIndex = 29;
            // 
            // wraithformlabel
            // 
            this.wraithformlabel.AutoSize = true;
            this.wraithformlabel.BackColor = System.Drawing.Color.Transparent;
            this.wraithformlabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wraithformlabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.wraithformlabel.Location = new System.Drawing.Point(347, 738);
            this.wraithformlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wraithformlabel.Name = "wraithformlabel";
            this.wraithformlabel.Size = new System.Drawing.Size(153, 25);
            this.wraithformlabel.TabIndex = 28;
            this.wraithformlabel.Text = "Wraith Form";
            // 
            // Wraithtimer
            // 
            this.Wraithtimer.AutoSize = true;
            this.Wraithtimer.BackColor = System.Drawing.Color.Transparent;
            this.Wraithtimer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wraithtimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Wraithtimer.Location = new System.Drawing.Point(573, 710);
            this.Wraithtimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Wraithtimer.Name = "Wraithtimer";
            this.Wraithtimer.Size = new System.Drawing.Size(0, 32);
            this.Wraithtimer.TabIndex = 33;
            this.Wraithtimer.Visible = false;
            // 
            // wraithformACTIVE
            // 
            this.wraithformACTIVE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wraithformACTIVE.Enabled = false;
            this.wraithformACTIVE.Image = ((System.Drawing.Image)(resources.GetObject("wraithformACTIVE.Image")));
            this.wraithformACTIVE.Location = new System.Drawing.Point(573, 657);
            this.wraithformACTIVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wraithformACTIVE.Name = "wraithformACTIVE";
            this.wraithformACTIVE.Size = new System.Drawing.Size(53, 49);
            this.wraithformACTIVE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wraithformACTIVE.TabIndex = 32;
            this.wraithformACTIVE.TabStop = false;
            this.wraithformACTIVE.Visible = false;
            // 
            // MutedLbl
            // 
            this.MutedLbl.AutoSize = true;
            this.MutedLbl.BackColor = System.Drawing.Color.Transparent;
            this.MutedLbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MutedLbl.ForeColor = System.Drawing.Color.Crimson;
            this.MutedLbl.Location = new System.Drawing.Point(1395, 263);
            this.MutedLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MutedLbl.Name = "MutedLbl";
            this.MutedLbl.Size = new System.Drawing.Size(89, 25);
            this.MutedLbl.TabIndex = 35;
            this.MutedLbl.Text = "Muted!";
            this.MutedLbl.Visible = false;
            // 
            // mutedPic
            // 
            this.mutedPic.BackColor = System.Drawing.Color.Transparent;
            this.mutedPic.Enabled = false;
            this.mutedPic.Image = ((System.Drawing.Image)(resources.GetObject("mutedPic.Image")));
            this.mutedPic.Location = new System.Drawing.Point(1399, 290);
            this.mutedPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mutedPic.Name = "mutedPic";
            this.mutedPic.Size = new System.Drawing.Size(79, 66);
            this.mutedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mutedPic.TabIndex = 34;
            this.mutedPic.TabStop = false;
            this.mutedPic.Visible = false;
            // 
            // SnakeRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1503, 802);
            this.Controls.Add(this.MutedLbl);
            this.Controls.Add(this.mutedPic);
            this.Controls.Add(this.Wraithtimer);
            this.Controls.Add(this.wraithformACTIVE);
            this.Controls.Add(this.wraithformX);
            this.Controls.Add(this.wraithformimage);
            this.Controls.Add(this.WraithformPointsCounter);
            this.Controls.Add(this.wraithformlabel);
            this.Controls.Add(this.overfedlbl);
            this.Controls.Add(this.overfedPic);
            this.Controls.Add(this.headachelbl);
            this.Controls.Add(this.headachePic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.focusCounter);
            this.Controls.Add(this.focusLabel);
            this.Controls.Add(this.FrenzyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frenzyEffectImage);
            this.Controls.Add(this.combatLogText);
            this.Controls.Add(this.combatLog);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.movementSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levelText);
            this.Controls.Add(this.lvlCounter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.LevelBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.pbCanvas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SnakeRPG";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake RPG";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frenzyEffectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headachePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overfedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wraithformimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wraithformACTIVE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutedPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar LevelBar;
        private System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lvlCounter;
        private System.Windows.Forms.Label levelText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label movementSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox combatLog;
        private System.Windows.Forms.Label combatLogText;
        private System.Windows.Forms.PictureBox frenzyEffectImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FrenzyLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label focusCounter;
        private System.Windows.Forms.Label focusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label headachelbl;
        private System.Windows.Forms.PictureBox headachePic;
        private System.Windows.Forms.Label overfedlbl;
        private System.Windows.Forms.PictureBox overfedPic;
        private System.Windows.Forms.Label wraithformX;
        private System.Windows.Forms.PictureBox wraithformimage;
        private System.Windows.Forms.Label WraithformPointsCounter;
        private System.Windows.Forms.Label wraithformlabel;
        private System.Windows.Forms.Label Wraithtimer;
        private System.Windows.Forms.PictureBox wraithformACTIVE;
        private System.Windows.Forms.Label MutedLbl;
        private System.Windows.Forms.PictureBox mutedPic;
    }
}

