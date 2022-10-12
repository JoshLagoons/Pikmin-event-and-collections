using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikminCoupling
{
    public interface Iobserver
    {
        void Update(Object sender, OlimarState state);
        void Update(OlimarState state);
    }
}
