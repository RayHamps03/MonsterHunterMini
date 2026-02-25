namespace MonsterHunterMini
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logo = new PictureBox();
            buttonPlay = new Button();
            buttonInfo = new Button();
            buttonQuit = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(568, 392);
            logo.Name = "logo";
            logo.Size = new Size(298, 151);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(48, 80);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(150, 50);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(48, 160);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(150, 50);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Info";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(48, 240);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(150, 50);
            buttonQuit.TabIndex = 3;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.MainMenuBG;
            ClientSize = new Size(884, 561);
            Controls.Add(buttonQuit);
            Controls.Add(buttonInfo);
            Controls.Add(buttonPlay);
            Controls.Add(logo);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Monster Hunter Mini";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logo;
        private Button buttonPlay;
        private Button buttonInfo;
        private Button buttonQuit;
    }
}
