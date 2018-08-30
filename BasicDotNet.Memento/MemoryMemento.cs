using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class MemoryMemento
    {
        string _Name;
        string _PhoneNumber;

        internal string Name { get { return _Name; } set { _Name = value; } }
        internal string PhoneNumber { get { return _PhoneNumber; } set { _PhoneNumber = value; } }
    }
}
