using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PikminCoupling
{
    public enum OlimarState 
    {
        Spawning, Moving, Throwing, whistle, Stunned, Dying, Dead

    }
    public class Olimar : Isubject
    {
        protected OlimarState state;
        public OlimarState State
        {
            get { return state; }
            set {
                if (value != state)
                {
                    Notify();
                    state = value;
                }
            }
        }
        public Olimar()
        { 
            this.pikmins = new List<Iobserver>();
            this.State = OlimarState.Throwing;
           
        }

        public List<Iobserver> pikmins { get; set; }
        List<string> Isubject.pikmins { get; set; }

        public void Notify()
        {
            foreach (Iobserver p in this.pikmins)
            {
                p.Update(this.State);
            }
        }

        public void Attatch(Iobserver observer)
        {
            this.pikmins.Add(observer);
        }

        public void Detetch(Iobserver observer)
        {
            this.pikmins.Remove(observer);
        }

        public void Notify(OlimarState state)
        {
           this.state = state;
        }
    }
}
