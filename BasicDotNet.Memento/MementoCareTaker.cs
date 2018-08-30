using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class MementoCareTaker
    {
        private MemoryMemento _Momento;

        internal void SetMomento(MemoryMemento momento)
        {
            _Momento = momento;
        }

        internal MemoryMemento GetMomento()
        {
            return _Momento;
        }

    }
}
