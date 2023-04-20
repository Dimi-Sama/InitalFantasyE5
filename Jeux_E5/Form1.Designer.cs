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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OctopathE5));
            this.textAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.actionLabel = new System.Windows.Forms.Label();
            this.Cloud = new System.Windows.Forms.PictureBox();
            this.healButton = new System.Windows.Forms.Button();
            this.doubleAttackButton = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.Monster = new System.Windows.Forms.PictureBox();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.monsterNameLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMonsterStats = new System.Windows.Forms.Label();
            this.lblPlayerStats = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textAnimationTimer
            // 
            this.textAnimationTimer.Interval = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Jeux_E5.Properties.Resources.textbox_pieces_1_;
            this.pictureBox1.Location = new System.Drawing.Point(400, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // actionLabel
            // 
            this.actionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actionLabel.AutoSize = true;
            this.actionLabel.BackColor = System.Drawing.Color.Navy;
            this.actionLabel.Font = new System.Drawing.Font("Alagard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.actionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionLabel.Location = new System.Drawing.Point(419, 551);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(79, 30);
            this.actionLabel.TabIndex = 1;
            this.actionLabel.Text = "Test";
            // 
            // Cloud
            // 
            this.Cloud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cloud.BackColor = System.Drawing.Color.Transparent;
            this.Cloud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cloud.Image = global::Jeux_E5.Properties.Resources._207000106_Idle;
            this.Cloud.Location = new System.Drawing.Point(796, 192);
            this.Cloud.Name = "Cloud";
            this.Cloud.Size = new System.Drawing.Size(252, 185);
            this.Cloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cloud.TabIndex = 2;
            this.Cloud.TabStop = false;
            // 
            // healButton
            // 
            this.healButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.healButton.Font = new System.Drawing.Font("Alagard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.healButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.healButton.Image = global::Jeux_E5.Properties.Resources.textbox_pieces_1_;
            this.healButton.Location = new System.Drawing.Point(12, 614);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(371, 55);
            this.healButton.TabIndex = 3;
            this.healButton.Text = "Heal";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click_1);
            // 
            // doubleAttackButton
            // 
            this.doubleAttackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doubleAttackButton.Font = new System.Drawing.Font("Alagard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.doubleAttackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doubleAttackButton.Image = global::Jeux_E5.Properties.Resources.textbox_pieces_1_;
            this.doubleAttackButton.Location = new System.Drawing.Point(12, 551);
            this.doubleAttackButton.Name = "doubleAttackButton";
            this.doubleAttackButton.Size = new System.Drawing.Size(371, 55);
            this.doubleAttackButton.TabIndex = 4;
            this.doubleAttackButton.Text = "Double Attack";
            this.doubleAttackButton.UseVisualStyleBackColor = true;
            this.doubleAttackButton.Click += new System.EventHandler(this.doubleAttackButton_Click_1);
            // 
            // attackButton
            // 
            this.attackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.attackButton.Font = new System.Drawing.Font("Alagard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.attackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.attackButton.Image = global::Jeux_E5.Properties.Resources.textbox_pieces_1_;
            this.attackButton.Location = new System.Drawing.Point(12, 490);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(371, 55);
            this.attackButton.TabIndex = 5;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click_1);
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerHealthBar.BackColor = System.Drawing.Color.Black;
            this.playerHealthBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.playerHealthBar.Location = new System.Drawing.Point(796, 376);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(247, 23);
            this.playerHealthBar.TabIndex = 6;
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monsterHealthBar.BackColor = System.Drawing.Color.Black;
            this.monsterHealthBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.monsterHealthBar.Location = new System.Drawing.Point(133, 376);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(182, 23);
            this.monsterHealthBar.TabIndex = 8;
            // 
            // Monster
            // 
            this.Monster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monster.BackColor = System.Drawing.Color.Transparent;
            this.Monster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Monster.Image = global::Jeux_E5.Properties.Resources._306001303_Standby;
            this.Monster.Location = new System.Drawing.Point(133, 192);
            this.Monster.Name = "Monster";
            this.Monster.Size = new System.Drawing.Size(182, 178);
            this.Monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Monster.TabIndex = 7;
            this.Monster.TabStop = false;
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Navy;
            this.playerNameLabel.Font = new System.Drawing.Font("Alagard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerNameLabel.ForeColor = System.Drawing.Color.White;
            this.playerNameLabel.Location = new System.Drawing.Point(806, 118);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(53, 15);
            this.playerNameLabel.TabIndex = 9;
            this.playerNameLabel.Text = "Cloud";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Jeux_E5.Properties.Resources.textbox_pieces_1_;
            this.pictureBox2.Location = new System.Drawing.Point(100, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // monsterNameLabel
            // 
            this.monsterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monsterNameLabel.AutoSize = true;
            this.monsterNameLabel.BackColor = System.Drawing.Color.Navy;
            this.monsterNameLabel.Font = new System.Drawing.Font("Alagard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.monsterNameLabel.ForeColor = System.Drawing.Color.White;
            this.monsterNameLabel.Location = new System.Drawing.Point(109, 118);
            this.monsterNameLabel.Name = "monsterNameLabel";
            this.monsterNameLabel.Size = new System.Drawing.Size(71, 15);
            this.monsterNameLabel.TabIndex = 10;
            this.monsterNameLabel.Text = "Dracky ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Jeux_E5.Properties.Resources.textbox_pieces_1_;
            this.pictureBox3.Location = new System.Drawing.Point(796, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // lblMonsterStats
            // 
            this.lblMonsterStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonsterStats.AutoSize = true;
            this.lblMonsterStats.BackColor = System.Drawing.Color.Navy;
            this.lblMonsterStats.Font = new System.Drawing.Font("Alagard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterStats.ForeColor = System.Drawing.Color.White;
            this.lblMonsterStats.Location = new System.Drawing.Point(109, 139);
            this.lblMonsterStats.Name = "lblMonsterStats";
            this.lblMonsterStats.Size = new System.Drawing.Size(44, 12);
            this.lblMonsterStats.TabIndex = 13;
            this.lblMonsterStats.Text = "label1";
            // 
            // lblPlayerStats
            // 
            this.lblPlayerStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerStats.AutoSize = true;
            this.lblPlayerStats.BackColor = System.Drawing.Color.Navy;
            this.lblPlayerStats.Font = new System.Drawing.Font("Alagard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerStats.ForeColor = System.Drawing.Color.White;
            this.lblPlayerStats.Location = new System.Drawing.Point(809, 139);
            this.lblPlayerStats.Name = "lblPlayerStats";
            this.lblPlayerStats.Size = new System.Drawing.Size(44, 12);
            this.lblPlayerStats.TabIndex = 14;
            this.lblPlayerStats.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Jeux_E5.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(1072, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Thunderstrike Laser", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(829, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Created by ChizuSama_";
            // 
            // OctopathE5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jeux_E5.Properties.Resources._646a5645d72ad40dbc18fcfcebb2ff03_700x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblPlayerStats);
            this.Controls.Add(this.lblMonsterStats);
            this.Controls.Add(this.monsterNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.monsterHealthBar);
            this.Controls.Add(this.Monster);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.doubleAttackButton);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.Cloud);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OctopathE5";
            this.Text = "InitialFantasyE5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox pictureBox4;
        private Label label1;
    }
}