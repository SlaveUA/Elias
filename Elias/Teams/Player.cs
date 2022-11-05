using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Elias.Teams;

namespace Elias
{
    public class Player : IPlayer
    {
        public string? Name { get; set; }

        
        public byte CountOfCorectAnswers { get; set; }
        public byte CountOfQestions { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
