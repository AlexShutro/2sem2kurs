using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1;

interface I1
{
    int Id { get; set; }
    void Method();
    event EventHandler Event;
    int this[int index] { get; set; }
}