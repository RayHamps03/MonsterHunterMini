namespace MonsterHunterMini.Forms
{
    partial class FormMain
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            huntBtn5 = new RadioButton();
            huntBtn4 = new RadioButton();
            huntBtn3 = new RadioButton();
            huntBtn2 = new RadioButton();
            huntBtn1 = new RadioButton();
            startBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.HunterListIcon;
            pictureBox1.Location = new Point(112, 384);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(huntBtn5);
            groupBox1.Controls.Add(huntBtn4);
            groupBox1.Controls.Add(huntBtn3);
            groupBox1.Controls.Add(huntBtn2);
            groupBox1.Controls.Add(huntBtn1);
            groupBox1.Font = new Font("Sitka Subheading", 14.2499981F);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(272, 344);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hunt Rank";
            // 
            // huntBtn5
            // 
            huntBtn5.AutoSize = true;
            huntBtn5.Font = new Font("Sitka Subheading", 14.2499981F);
            huntBtn5.ForeColor = SystemColors.ControlLightLight;
            huntBtn5.Location = new Point(8, 152);
            huntBtn5.Name = "huntBtn5";
            huntBtn5.Size = new Size(88, 32);
            huntBtn5.TabIndex = 4;
            huntBtn5.TabStop = true;
            huntBtn5.Text = "Master";
            huntBtn5.UseVisualStyleBackColor = true;
            // 
            // huntBtn4
            // 
            huntBtn4.AutoSize = true;
            huntBtn4.Font = new Font("Sitka Subheading", 14.2499981F);
            huntBtn4.ForeColor = SystemColors.ControlLightLight;
            huntBtn4.Location = new Point(8, 120);
            huntBtn4.Name = "huntBtn4";
            huntBtn4.Size = new Size(115, 32);
            huntBtn4.TabIndex = 3;
            huntBtn4.TabStop = true;
            huntBtn4.Text = "Very Hard";
            huntBtn4.UseVisualStyleBackColor = true;
            // 
            // huntBtn3
            // 
            huntBtn3.AutoSize = true;
            huntBtn3.Font = new Font("Sitka Subheading", 14.2499981F);
            huntBtn3.ForeColor = SystemColors.ControlLightLight;
            huntBtn3.Location = new Point(8, 88);
            huntBtn3.Name = "huntBtn3";
            huntBtn3.Size = new Size(72, 32);
            huntBtn3.TabIndex = 2;
            huntBtn3.TabStop = true;
            huntBtn3.Text = "Hard";
            huntBtn3.UseVisualStyleBackColor = true;
            // 
            // huntBtn2
            // 
            huntBtn2.AutoSize = true;
            huntBtn2.Font = new Font("Sitka Subheading", 14.2499981F);
            huntBtn2.ForeColor = SystemColors.ControlLightLight;
            huntBtn2.Location = new Point(8, 56);
            huntBtn2.Name = "huntBtn2";
            huntBtn2.Size = new Size(98, 32);
            huntBtn2.TabIndex = 1;
            huntBtn2.TabStop = true;
            huntBtn2.Text = "Medium";
            huntBtn2.UseVisualStyleBackColor = true;
            // 
            // huntBtn1
            // 
            huntBtn1.AutoSize = true;
            huntBtn1.Font = new Font("Sitka Subheading", 14.2499981F);
            huntBtn1.ForeColor = SystemColors.ControlLightLight;
            huntBtn1.Location = new Point(8, 24);
            huntBtn1.Name = "huntBtn1";
            huntBtn1.Size = new Size(69, 32);
            huntBtn1.TabIndex = 0;
            huntBtn1.TabStop = true;
            huntBtn1.Text = "Easy";
            huntBtn1.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            startBtn.FlatStyle = FlatStyle.Popup;
            startBtn.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startBtn.Location = new Point(496, 392);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(280, 112);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start Hunt!";
            startBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(144, 168);
            label1.Name = "label1";
            label1.Size = new Size(595, 30);
            label1.TabIndex = 3;
            label1.Text = "WIP || NEED TO IMPLEMENT ARMOR AND WEAPON SELECTION";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MainBG;
            ClientSize = new Size(884, 561);
            Controls.Add(label1);
            Controls.Add(startBtn);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Monster Hunter Mini - Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton huntBtn5;
        private RadioButton huntBtn4;
        private RadioButton huntBtn3;
        private RadioButton huntBtn2;
        private RadioButton huntBtn1;
        private Button startBtn;
        private Label label1;
    }
}