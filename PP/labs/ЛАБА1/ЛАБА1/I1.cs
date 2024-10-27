using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1;

interface I1
{
    int Id { get; set; } //свойство
    void Method(); //метод
    
    event EventHandler Event; //событие
    int this[int index] { get; set; } //индексатор
}