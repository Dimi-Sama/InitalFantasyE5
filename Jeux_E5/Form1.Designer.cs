namespace Jeux_E5
{
    partial class OctopathE5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textAnimationTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            actionLabel = new Label();
            Cloud = new PictureBox();
            healButton = new Button();
            doubleAttackButton = new Button();
            attackButton = new Button();
            playerHealthBar = new ProgressBar();
            monsterHealthBar = new ProgressBar();
            Monster = new PictureBox();
            playerNameLabel = new Label();
            pictureBox2 = new PictureBox();
            monsterNameLabel = new Label();
            pictureBox3 = new PictureBox();
            lblMonsterStats = new Label();
            lblPlayerStats = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Monster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textAnimationTimer
            // 
            textAnimationTimer.Interval = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.textbox_pieces_1_;
            pictureBox1.Location = new Point(400, 536);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(772, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.BackColor = Color.Navy;
            actionLabel.Font = new Font("Goudy Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            actionLabel.ForeColor = SystemColors.ControlLightLight;
            actionLabel.Location = new Point(419, 551);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(73, 37);
            actionLabel.TabIndex = 1;
            actionLabel.Text = "Test";
            // 
            // Cloud
            // 
            Cloud.BackColor = Color.Transparent;
            Cloud.BackgroundImageLayout = ImageLayout.Zoom;
            Cloud.Image = Properties.Resources._207000106_Idle;
            Cloud.Location = new Point(796, 192);
            Cloud.Name = "Cloud";
            Cloud.Size = new Size(252, 185);
            Cloud.SizeMode = PictureBoxSizeMode.Zoom;
            Cloud.TabIndex = 2;
            Cloud.TabStop = false;
            // 
            // healButton
            // 
            healButton.Font = new Font("Goudy Old Style", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            healButton.ForeColor = SystemColors.ControlLightLight;
            healButton.Image = Properties.Resources.textbox_pieces_1_;
            healButton.Location = new Point(12, 614);
            healButton.Name = "healButton";
            healButton.Size = new Size(371, 55);
            healButton.TabIndex = 3;
            healButton.Text = "Heal";
            healButton.UseVisualStyleBackColor = true;
            healButton.Click += healButton_Click;
            // 
            // doubleAttackButton
            // 
            doubleAttackButton.Font = new Font("Goudy Old Style", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            doubleAttackButton.ForeColor = SystemColors.ControlLightLight;
            doubleAttackButton.Image = Properties.Resources.textbox_pieces_1_;
            doubleAttackButton.Location = new Point(12, 551);
            doubleAttackButton.Name = "doubleAttackButton";
            doubleAttackButton.Size = new Size(371, 55);
            doubleAttackButton.TabIndex = 4;
            doubleAttackButton.Text = "Double Attack";
            doubleAttackButton.UseVisualStyleBackColor = true;
            doubleAttackButton.Click += doubleAttackButton_Click;
            // 
            // attackButton
            // 
            attackButton.BackgroundImageLayout = ImageLayout.None;
            attackButton.Font = new Font("Goudy Old Style", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            attackButton.ForeColor = SystemColors.ControlLightLight;
            attackButton.Image = Properties.Resources.textbox_pieces_1_;
            attackButton.Location = new Point(12, 490);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(371, 55);
            attackButton.TabIndex = 5;
            attackButton.Text = "Attack";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += attackButton_Click_1;
            // 
            // playerHealthBar
            // 
            playerHealthBar.BackColor = Color.Black;
            playerHealthBar.ForeColor = Color.Chartreuse;
            playerHealthBar.Location = new Point(854, 376);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(189, 23);
            playerHealthBar.TabIndex = 6;
            // 
            // monsterHealthBar
            // 
            monsterHealthBar.BackColor = Color.Black;
            monsterHealthBar.ForeColor = Color.Chartreuse;
            monsterHealthBar.Location = new Point(133, 376);
            monsterHealthBar.Name = "monsterHealthBar";
            monsterHealthBar.Size = new Size(182, 23);
            monsterHealthBar.TabIndex = 8;
            // 
            // Monster
            // 
            Monster.BackColor = Color.Transparent;
            Monster.BackgroundImageLayout = ImageLayout.Zoom;
            Monster.Image = Properties.Resources._306001303_Standby;
            Monster.Location = new Point(133, 192);
            Monster.Name = "Monster";
            Monster.Size = new Size(182, 178);
            Monster.SizeMode = PictureBoxSizeMode.Zoom;
            Monster.TabIndex = 7;
            Monster.TabStop = false;
            // 
            // playerNameLabel
            // 
            playerNameLabel.AutoSize = true;
            playerNameLabel.BackColor = Color.Navy;
            playerNameLabel.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerNameLabel.ForeColor = Color.White;
            playerNameLabel.Location = new Point(806, 118);
            playerNameLabel.Name = "playerNameLabel";
            playerNameLabel.Size = new Size(51, 21);
            playerNameLabel.TabIndex = 9;
            playerNameLabel.Text = "Cloud";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.textbox_pieces_1_;
            pictureBox2.Location = new Point(100, 109);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // monsterNameLabel
            // 
            monsterNameLabel.AutoSize = true;
            monsterNameLabel.BackColor = Color.Navy;
            monsterNameLabel.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            monsterNameLabel.ForeColor = Color.White;
            monsterNameLabel.Location = new Point(109, 118);
            monsterNameLabel.Name = "monsterNameLabel";
            monsterNameLabel.Size = new Size(61, 21);
            monsterNameLabel.TabIndex = 10;
            monsterNameLabel.Text = "Dracky ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.textbox_pieces_1_;
            pictureBox3.Location = new Point(796, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lblMonsterStats
            // 
            lblMonsterStats.AutoSize = true;
            lblMonsterStats.BackColor = Color.Navy;
            lblMonsterStats.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonsterStats.ForeColor = Color.White;
            lblMonsterStats.Location = new Point(109, 139);
            lblMonsterStats.Name = "lblMonsterStats";
            lblMonsterStats.Size = new Size(48, 21);
            lblMonsterStats.TabIndex = 13;
            lblMonsterStats.Text = "label1";
            // 
            // lblPlayerStats
            // 
            lblPlayerStats.AutoSize = true;
            lblPlayerStats.BackColor = Color.Navy;
            lblPlayerStats.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerStats.ForeColor = Color.White;
            lblPlayerStats.Location = new Point(809, 139);
            lblPlayerStats.Name = "lblPlayerStats";
            lblPlayerStats.Size = new Size(48, 21);
            lblPlayerStats.TabIndex = 14;
            lblPlayerStats.Text = "label1";
            // 
            // OctopathE5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._646a5645d72ad40dbc18fcfcebb2ff03_700x400;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 681);
            Controls.Add(lblPlayerStats);
            Controls.Add(lblMonsterStats);
            Controls.Add(monsterNameLabel);
            Controls.Add(playerNameLabel);
            Controls.Add(monsterHealthBar);
            Controls.Add(Monster);
            Controls.Add(playerHealthBar);
            Controls.Add(attackButton);
            Controls.Add(doubleAttackButton);
            Controls.Add(healButton);
            Controls.Add(Cloud);
            Controls.Add(actionLabel);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OctopathE5";
            Text = "InitialFantasyE5";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)Monster).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer textAnimationTimer;
        private PictureBox pictureBox1;
        private Label actionLabel;
        private PictureBox Cloud;
        private Button healButton;
        private Button doubleAttackButton;
        private Button attackButton;
        private ProgressBar playerHealthBar;
        private ProgressBar monsterHealthBar;
        private PictureBox Monster;
        private Label playerNameLabel;
        private PictureBox pictureBox2;
        private Label monsterNameLabel;
        private PictureBox pictureBox3;
        private Label lblMonsterStats;
        private Label lblPlayerStats;
    }
}