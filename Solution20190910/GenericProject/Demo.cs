using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProject
{
    class Demo<T>
    {

        public T ReturnType(T param)
        {
            return param;
        }

    }
}
