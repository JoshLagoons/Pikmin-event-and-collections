using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PikminCoupling
{
    public enum PikminState
    {
        Spawning, Moving, Thrown, Follow, Dying, Dead

    }
    public class Pikmin : Iobserver
    {
        public PikminState State;
        //Olimar oli;
        public Pikmin(Olimar oli)
        {
            this.State = PikminState.Thrown;
            //this.oli = oli;
            oli.Attatch(this); //weak reference the pikmin is attached to olimar.
        }

        public void Update(OlimarState state)
        {
            //WriteLine("pikmin update is called.");
            switch(state)
            {
                case OlimarState.Spawning:
                case OlimarState.Moving:
                case OlimarState.Throwing:
                
                case OlimarState.Stunned:
                case OlimarState.Dying:
                case OlimarState.Dead:
                    this.State = PikminState.Thrown;
                    WriteLine("the captain threw me, lets go!");
                    break;
                case OlimarState.whistle:
                    this.State = PikminState.Follow;
                    WriteLine("oh whats that whistle better follow!");
                        break;
            }
        }

    }
}
