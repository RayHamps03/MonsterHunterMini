using MonsterHunterMini.Database;
using MonsterHunterMini;
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

        // Allow creating a battle for a specific monster
        public FormBattle(Monster hunted, Player player) : this()
        {
            HuntedMonster = hunted;
            p1 = player;
        }

        private void FormBattle_Load(object sender, EventArgs e)
        {
            label1.Text = $"{p1.Name} encounters a {HuntedMonster.Name}!";
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            
            double winRate = CalculateWinRate(p1, HuntedMonster);
            DetermineWin((int)winRate);
        }

        // The hunted monster instance. Can be provided via constructor.
        Monster HuntedMonster;
        Player p1 = new Player("Hunter");
        

        // TEMPORARY CODE - Battle logic here
        // baseWinRate will be a variable determined from quest difficulty
        double baseWinRate = 80;


        /// <summary>
        /// Calculates the player's win rate as a percentage when facing a specified monster, based on their respective
        /// attack and defense values. The result is adjusted to ensure it remains within the valid range of 0 to
        /// 100 percent.
        /// <param name="player">The player whose win rate is being calculated. This parameter must not be null and should have valid
        /// equipped armor and weapon.</param>
        /// <param name="monster">The monster that the player is competing against. This parameter must not be null and should have valid
        /// defense and attack values.</param>
        /// <returns>A double representing the player's win rate as a percentage, constrained between 0 and 100.</returns>
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

        /// <summary>
        /// Determines the outcome of a game round based on the specified win probability and displays the result to the
        /// user.
        /// </summary>
        /// <param name="winRate">The probability of winning, expressed as a percentage from 1 to 100. Higher values increase the chance of
        /// winning.</param>
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
