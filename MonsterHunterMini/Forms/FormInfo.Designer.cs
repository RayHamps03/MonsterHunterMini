namespace MonsterHunterMini
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            buttonReturn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(376, 450);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(150, 50);
            buttonReturn.TabIndex = 3;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(256, 104);
            label1.Name = "label1";
            label1.Size = new Size(384, 35);
            label1.TabIndex = 4;
            label1.Text = "What is MONSTER HUNTER Mini?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(104, 216);
            label2.Name = "label2";
            label2.Size = new Size(675, 140);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.InfoBG;
            ClientSize = new Size(884, 561);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonReturn);
            MaximizeBox = false;
            Name = "FormInfo";
            Text = "Monster Hunter Mini - Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReturn;
        private Label label1;
        private Label label2;
    }
}