using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikminCoupling
{
    public class TWEvent
    {
        //throw and whistle event
        public int throwing { get; set; }
        public int whistling { get; set; }

        public event  EventHandler onThrowing;
        public event EventHandler onWhistle;

        protected int thrownamount;
        public int thrownAmount { get => thrownamount; set => thrownamount = value; }

        protected int whistledamount;
        public int whistleAmount { get => whistledamount; set => whistledamount = value; }

        public TWEvent()
        {
            this.onThrowing += onThrowing;
            this.throwing = 1;
            this.onWhistle += onWhistle;
            this.whistling = 100;
        }
        protected void OnThrow(object sender, EventArgs e)
        {
            this.throwing++;
        }
        public void Throwing()
        {
            this.onThrowing.Invoke(this, EventArgs.Empty);
        }
        protected void OnWhistle(object sender, EventArgs e)
        {
            this.whistling++;
        }
        public void Whistling()
        {
            this.onWhistle.Invoke(this, EventArgs.Empty);
        }
    }
}
