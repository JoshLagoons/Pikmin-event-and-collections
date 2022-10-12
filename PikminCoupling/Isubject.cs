using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikminCoupling
{
    public interface Isubject
    {
        List<string> pikmins { get; set; }
        void Attatch(Iobserver observer);
        void Detetch(Iobserver observer);
        void Notify(OlimarState state);
    }
}
