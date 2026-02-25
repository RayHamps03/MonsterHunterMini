namespace MonsterHunterMini.Forms
{
    partial class FormBattle
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
            label1 = new Label();
            buttonBegin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(253, 141);
            label1.Name = "label1";
            label1.Size = new Size(380, 30);
            label1.TabIndex = 4;
            label1.Text = "WIP || NEED TO IMPLEMENT BATTLE UI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBegin
            // 
            buttonBegin.Location = new Point(337, 269);
            buttonBegin.Name = "buttonBegin";
            buttonBegin.Size = new Size(159, 85);
            buttonBegin.TabIndex = 5;
            buttonBegin.Text = "Let's hunt!";
            buttonBegin.UseVisualStyleBackColor = true;
            buttonBegin.Click += buttonBegin_Click;
            // 
            // FormBattle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BattleBG;
            ClientSize = new Size(884, 561);
            Controls.Add(buttonBegin);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormBattle";
            Text = "Monster Hunter Mini - Battle";
            Load += FormBattle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBegin;
    }
}