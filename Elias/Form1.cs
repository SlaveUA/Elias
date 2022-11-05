using Elias.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Components
            var TeamNameLabel = new Label
            {
                Location = new Point(250, 30),
                Size = new Size(300, 50),
                Text = "Input Teams Name",
                Font = new Font("Segoe UI", 20, FontStyle.Regular)
            };

            var NameOfFirstTeamTextBox = new TextBox
            {
                Location = new Point(50, 100),
                Size = new Size(200, 30),
                Text = "Team1",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.Aqua,
            };

            var NameOfSecondTeamTextBox = new TextBox
            {
                Location = new Point(550, 100),
                Size = new Size(200, 30),
                Text = "Team2",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.Aqua,
            };

            var PlayerNameLabel = new Label
            {
                Location = new Point(250, 150),
                Size = new Size(350, 50),
                Text = "Input Players Name",
                Font = new Font("Segoe UI", 20, FontStyle.Regular)
            };

            var NameOfFirstPlayerTextBox = new TextBox
            {
                Location = new Point(50, 250),
                Size = new Size(200, 30),
                Text = "Player1",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.Aqua,
            };

            var NameOfSecondPlayerTextBox = new TextBox
            {
                Location = new Point(50, 330),
                Size = new Size(200, 30),
                Text = "Player2",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.Aqua,
            };

            var NameOfThirdPlayerTextBox = new TextBox
            {
                Location = new Point(550, 250),
                Size = new Size(200, 30),
                Text = "Player3",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.Aqua,
            };

            var NameOfFourthPlayerTextBox = new TextBox
            {
                Location = new Point(550, 330),
                Size = new Size(200, 30),
                Text = "Player4",
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.Aqua,
            };

            var SafeAndStartButton = new Button
            {
                Location = new Point(300, 400),
                Size = new Size(200, 70),
                Text = "Safe and Start",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.LightSkyBlue,
            };
            #endregion

            #region Controls
            Controls.Add(TeamNameLabel);
            Controls.Add(PlayerNameLabel);
            Controls.Add(NameOfFirstTeamTextBox);
            Controls.Add(NameOfSecondTeamTextBox);
            Controls.Add(NameOfFirstPlayerTextBox);
            Controls.Add(NameOfSecondPlayerTextBox);
            Controls.Add(NameOfThirdPlayerTextBox);
            Controls.Add(NameOfFourthPlayerTextBox);
            Controls.Add(SafeAndStartButton);
            #endregion

            SafeAndStartButton.Click += (s, e) =>
            {
                var FirstTeam = new Team
                {
                    TeamName = NameOfFirstTeamTextBox.Text,
                    Players = new List<IPlayer> 
                    { 
                        new Player { Name = NameOfFirstPlayerTextBox.Text },
                        new Player { Name = NameOfSecondPlayerTextBox.Text },
                    },
                };

                var SecondTeam = new Team
                {
                    TeamName = NameOfSecondTeamTextBox.Text,
                    Players = new List<IPlayer>
                    {
                        new Player { Name = NameOfThirdPlayerTextBox.Text },
                        new Player { Name = NameOfFourthPlayerTextBox.Text },
                    },
                };

                var GameForm = new GameForm(FirstTeam, SecondTeam);
                GameForm.Show();
                Hide();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
