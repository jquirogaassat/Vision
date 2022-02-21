using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICrud<T>
    {
        bool Add(T entAlta);
        bool Delete(T entAlta); 
        bool Update(T entAlta);
        IList<T> GetAll();

    }
}
