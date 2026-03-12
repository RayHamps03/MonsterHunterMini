using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonsterHunterMini.Forms
{
    public partial class FormCraftUpgradeSelect : Form
    {
        public FormCraftUpgradeSelect()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonCraftArmor_Click(object sender, EventArgs e)
        {
            Close();
            FormCraftArmor craftArmor = new();
            craftArmor.Show();
        }
    }
}
