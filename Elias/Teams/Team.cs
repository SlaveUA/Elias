using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elias.Teams;

namespace Elias
{
    public class Team : ITeam
    {
        public string? TeamName { get; set; }
        public byte TeamPoints { get; set; }

        public List <IPlayer>? Players { get; set; }
    }
}
