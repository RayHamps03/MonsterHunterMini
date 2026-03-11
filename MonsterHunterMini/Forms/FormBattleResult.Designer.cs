namespace MonsterHunterMini.Forms
{
    partial class FormBattleResult
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
            labelResult = new Label();
            listMaterials = new ListBox();
            buttonCollect = new Button();
            SuspendLayout();
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(195, 9);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(97, 15);
            labelResult.TabIndex = 0;
            labelResult.Text = "Materials gained:";
            // 
            // listMaterials
            // 
            listMaterials.Font = new Font("Segoe UI", 12F);
            listMaterials.FormattingEnabled = true;
            listMaterials.Location = new Point(115, 42);
            listMaterials.Name = "listMaterials";
            listMaterials.Size = new Size(260, 88);
            listMaterials.TabIndex = 1;
            // 
            // buttonCollect
            // 
            buttonCollect.Location = new Point(164, 150);
            buttonCollect.Name = "buttonCollect";
            buttonCollect.Size = new Size(158, 70);
            buttonCollect.TabIndex = 2;
            buttonCollect.Text = "Collect";
            buttonCollect.UseVisualStyleBackColor = true;
            buttonCollect.Click += buttonCollect_Click;
            // 
            // FormBattleResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 255);
            Controls.Add(buttonCollect);
            Controls.Add(listMaterials);
            Controls.Add(labelResult);
            Name = "FormBattleResult";
            Text = "FormBattleResult";
            Load += FormBattleResult_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResult;
        private ListBox listMaterials;
        private Button buttonCollect;
    }
}