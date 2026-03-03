namespace MonsterHunterMini.Forms
{
    partial class QuestSelect
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
            listQuests = new ListBox();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // listQuests
            // 
            listQuests.FormattingEnabled = true;
            listQuests.Location = new Point(30, 12);
            listQuests.Name = "listQuests";
            listQuests.Size = new Size(336, 394);
            listQuests.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(109, 472);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(189, 80);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start hunt";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // QuestSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 592);
            Controls.Add(buttonStart);
            Controls.Add(listQuests);
            Name = "QuestSelect";
            Text = "QuestSelect";
            Load += QuestSelect_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listQuests;
        private Button buttonStart;
    }
}