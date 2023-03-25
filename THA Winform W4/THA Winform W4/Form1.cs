using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static THA_Winform_W4.Form1;

namespace THA_Winform_W4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Team> team = new List<Team>();
        public class Team
        {
            public List<Player> Players = new List<Player>();
            private string teamName;
            public string Teamname
            {
                get { return teamName; }
                set { teamName = value; }
            }
            private string teamCountry;
            public string Teamcountry
            {
                get { return teamCountry; }
                set { teamCountry = value; }
            }
            private string teamCity;
            public string Teamcity
            {
                get { return teamCity; }
                set { teamCity = value; }
            }
            public Team(string name, string country, string city)
            {
                this.teamName = name;
                this.teamCountry = country;
                this.teamCity = city;
            }
        }
        public class Player
        {
            private string playerName;
            public string Playername
            {
                get { return playerName; }
                set { playerName = value; }
            }
            private string playerNum;
            public string Playernum
            {
                get { return playerNum; }
                set { playerNum = value; }
            }
            private string playerPos;
            public string Playerpos
            {
                get { return playerPos; }
                set { playerPos = value; }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBoxPosition.Items.Add("GK", "DF", "MF", "FW");
        }

        private void textBoxTeamName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxTeamCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTeamCity_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTeam.Items.Clear();
            foreach (Team tim in team)
            {
                if (comboBoxCountry.Text == tim.Teamcountry)
                {
                    comboBoxTeam.Items.Add(tim.Teamname);
                }
            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team tim in team)
            {
                if (comboBoxTeam.Text == tim.Teamname)
                {
                    foreach (Player pemain in tim.Players)
                    {
                        listBox1.Items.Add("(" + pemain.Playernum + ") " + pemain.Playername + ", " + pemain.Playerpos);
                    }
                }
            }
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            
            if (textBoxTeamName.Text != "" || textBoxTeamCountry.Text != "" || textBoxTeamCity.Text != "")
            {
                Team tim = new Team(textBoxTeamName.Text, textBoxTeamCountry.Text, textBoxTeamCity.Text);
                foreach (Team team1 in team)
                {
                    if (team1.Teamname == tim.Teamname)
                    {
                        MessageBox.Show("Team allready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        team.Add(tim);
                        foreach (Team tem in team)
                        {
                            if (!comboBoxCountry.Items.Contains(tem.Teamcountry))
                            {
                                comboBoxCountry.Items.Add(tem.Teamcountry);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields need to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text != "" || textBoxPlayerNumber.Text != "" || comboBoxPosition.Text != "")
            {
                //Player pemain = new Player(tim.Players, textBoxPlayerName.Text, textBoxPlayerNumber.Text, comboBoxPlayerPosition.Text);
                foreach (Team tim in team)
                {
                    foreach (Player players in tim.Players)
                    if (textBoxPlayerName.Text != players.Playername)
                    {
                        comboBoxTeam.Items.Add(textBoxPlayerName.Text);
                    }
                    else
                    {
                        MessageBox.Show("Player allready exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }
        }
    }
}
