namespace MonsterHunterMini.Forms
{
    partial class CreateUserForm
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
            lblGreetings = new Label();
            txtPlayerName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.Font = new Font("Segoe UI", 13F);
            lblGreetings.Location = new Point(106, 23);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(169, 25);
            lblGreetings.TabIndex = 0;
            lblGreetings.Text = "What is your name?";
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(79, 83);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(216, 23);
            txtPlayerName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(276, 78);
            btnSave.TabIndex = 2;
            btnSave.Text = "Create Player";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 230);
            Controls.Add(btnSave);
            Controls.Add(txtPlayerName);
            Controls.Add(lblGreetings);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGreetings;
        private TextBox txtPlayerName;
        private Button btnSave;
    }
}