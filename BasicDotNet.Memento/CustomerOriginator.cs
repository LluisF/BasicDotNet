using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class CustomerOriginator
    {
        string _Name;
        string _PhoneNumber;

        internal string Name { get { return _Name; } set { _Name = value; } }
        internal string PhoneNumber { get { return _PhoneNumber; } set { _PhoneNumber = value; } }

        internal void Restore(MemoryMemento mem)
        {
            this.Name = mem.Name;
            this.PhoneNumber = mem.PhoneNumber;
        }

        internal MemoryMemento SaveMomento()
        {
            MemoryMemento momento = new MemoryMemento();
            momento.Name = _Name;
            momento.PhoneNumber = _PhoneNumber;
            return momento;
        }

    }
}
