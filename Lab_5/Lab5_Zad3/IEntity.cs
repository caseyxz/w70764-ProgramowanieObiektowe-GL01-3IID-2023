using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{
    using System;

    public interface IEntity<T>
    {
        T Id { get; set; }
    }

}
