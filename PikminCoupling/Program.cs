using static System.Console;

namespace PikminCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Olimar oli = new Olimar();
            WriteLine(oli.State);
            Pikmin RedPikmin = new Pikmin(oli);
            Pikmin PurplePikmin = new Pikmin(oli);
            WriteLine(RedPikmin.State);
            WriteLine(PurplePikmin.State);

            oli.State = OlimarState.Throwing;
            oli.State = OlimarState.whistle;

            
            ReadLine();
        }
    }
}