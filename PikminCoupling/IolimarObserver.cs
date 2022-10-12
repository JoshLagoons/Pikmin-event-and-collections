using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikminCoupling
{
    public interface IolimarObserver:Iobserver
    {
        void Update(OlimarState o);
    }
}
