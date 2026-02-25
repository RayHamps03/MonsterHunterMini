using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonsterHunterMini.Forms
{
    public partial class FormBattle : Form
    {
        public FormBattle()
        {
            InitializeComponent();
        }

        private void FormBattle_Load(object sender, EventArgs e)
        {
            label1.Text = $"A {HuntedMonster.Name} appears!";
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            double winRate = CalculateWinRate(p1, HuntedMonster);
            DetermineWin((int)winRate);
        }

        // TEMPORARY CODE - Database connection to get monster here
        Monster HuntedMonster = new Monster("Rathalos", 7, 7, null);
        Player p1 = new Player("Hunter");
        

        // TEMPORARY CODE - Battle logic here
        // baseWinRate will be a variable determined from quest difficulty
        double baseWinRate = 80;



        double CalculateWinRate(Player player, Monster monster)
        {
            // Calculate the player's total defense and attack values
            double playerDefense = player.EquippedArmor.Defense;
            double playerAttack = player.EquippedWeapon.Attack;
            // Calculate the monster's total defense and attack values
            double monsterDefense = monster.Defense;
            double monsterAttack = monster.Attack;
            // Calculate the win rate based on the player's and monster's stats
            double winRate = baseWinRate + (playerAttack - monsterDefense) * 2 - (monsterAttack - playerDefense) * 2;
            // Ensure the win rate is between 0% and 100%
            winRate = Math.Max(0, Math.Min(100, winRate));
            return winRate;
        }

        void DetermineWin(int winRate)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 101);

            if (roll <= winRate)
            {
                MessageBox.Show("You win!");
                this.Close();
                Form1 mainMenu = new Form1();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("You lose!");
                this.Close();
                Form1 mainMenu = new Form1();
                mainMenu.Show();

            }
        }

        
    }
}
