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
    public partial class GameForm : Form
    {
        public GameForm(Team Team1, Team Team2)
        {
            InitializeComponent();

            var StartGameButton = new Button
            {
                Location = new Point(300, 400),
                Size = new Size(200, 70),
                Text = "Start game",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                BackColor = Color.LightSkyBlue,
            };
            var TeamsInfoLabel = new Label
            {
                Size = new Size(500,80),
                Location = new Point(200, 200),
                Text = $"First team name:{Team1.TeamName} and teammates: {Team1.Players[0]} and {Team1.Players[1]}. Second team name: {Team2.TeamName} and teammates: {Team2.Players[0]} and {Team2.Players[1]}"
                
            };
            Controls.Add(StartGameButton);
            Controls.Add(TeamsInfoLabel);

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
