namespace MonsterHunterMini.Forms
{
    partial class FormCraftArmor
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
            listArmor = new ListBox();
            buttonCraft = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // listArmor
            // 
            listArmor.FormattingEnabled = true;
            listArmor.Location = new Point(32, 55);
            listArmor.Name = "listArmor";
            listArmor.Size = new Size(312, 349);
            listArmor.TabIndex = 0;
            // 
            // buttonCraft
            // 
            buttonCraft.Location = new Point(405, 263);
            buttonCraft.Name = "buttonCraft";
            buttonCraft.Size = new Size(208, 141);
            buttonCraft.TabIndex = 1;
            buttonCraft.Text = "Craft";
            buttonCraft.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(405, 436);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(208, 39);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormCraftArmor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 557);
            Controls.Add(buttonExit);
            Controls.Add(buttonCraft);
            Controls.Add(listArmor);
            Name = "FormCraftArmor";
            Text = "FormCraftArmor";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listArmor;
        private Button buttonCraft;
        private Button buttonExit;
    }
}