using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikminCoupling
{
    public class PikminOnion 
    {
        public List<Pikmin> Pikmins;
        public int throwAmounf { get; set; }
        public int WhistleAmount { get; set; }

        public PikminOnion()
        {
            Pikmins = new List<Pikmin>();
            this.throwAmounf = 1;
            this.WhistleAmount = 100;

        }
        public void AddPikmin(Pikmin p)
        {
            Pikmins.Add(p);
            p.OnThrow += P_OnThrow;
            p.OnWhistle += P_OnWhistle;
        }
        public void RemovePikmin(Pikmin p)
        {
            Pikmins.Add(p);
            p.OnThrow -= P_OnThrow;
            p.OnWhistle -= P_OnWhistle;
        }
        private void P_OnThrow(object sender, EventArgs e)
        {
            Pikmin p = (Pikmin)sender;
            this.throwAmounf += p.onThrowing;
        }
        private void P_OnWhistle(object sender, EventArgs e)
        {
            Pikmin p = (Pikmin)sender;
            this.WhistleAmount += p.onWhistle;
        }
    }
}
