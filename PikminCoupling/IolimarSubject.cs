using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikminCoupling
{
    public interface IolimarSubject : Isubject
    {
        List<IolimarObserver> observers { get; set; }

        void Attatch(IolimarObserver o);

        void Detatch(IolimarObserver o);
    }
}
