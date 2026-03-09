namespace MonsterHunterMini.Forms
{
    partial class FormCraftUpgradeSelect
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
            buttonCraftArmor = new Button();
            buttonCraftWeapon = new Button();
            buttonUpgrade = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonCraftArmor
            // 
            buttonCraftArmor.Location = new Point(50, 29);
            buttonCraftArmor.Name = "buttonCraftArmor";
            buttonCraftArmor.Size = new Size(165, 91);
            buttonCraftArmor.TabIndex = 0;
            buttonCraftArmor.Text = "Craft Armor";
            buttonCraftArmor.UseVisualStyleBackColor = true;
            // 
            // buttonCraftWeapon
            // 
            buttonCraftWeapon.Location = new Point(50, 150);
            buttonCraftWeapon.Name = "buttonCraftWeapon";
            buttonCraftWeapon.Size = new Size(165, 91);
            buttonCraftWeapon.TabIndex = 1;
            buttonCraftWeapon.Text = "Craft Weapon";
            buttonCraftWeapon.UseVisualStyleBackColor = true;
            // 
            // buttonUpgrade
            // 
            buttonUpgrade.Location = new Point(50, 285);
            buttonUpgrade.Name = "buttonUpgrade";
            buttonUpgrade.Size = new Size(165, 91);
            buttonUpgrade.TabIndex = 2;
            buttonUpgrade.Text = "Upgrade";
            buttonUpgrade.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(50, 438);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(165, 42);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // FormCraftUpgradeSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 547);
            Controls.Add(buttonExit);
            Controls.Add(buttonUpgrade);
            Controls.Add(buttonCraftWeapon);
            Controls.Add(buttonCraftArmor);
            Name = "FormCraftUpgradeSelect";
            Text = "FormCraftUpgradeSelect";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCraftArmor;
        private Button buttonCraftWeapon;
        private Button buttonUpgrade;
        private Button buttonExit;
    }
}