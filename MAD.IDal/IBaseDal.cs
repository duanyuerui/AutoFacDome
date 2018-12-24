using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.IDal
{
    public interface IBaseDal<T>  where T : class, new()
    {
        string Add();

        string Update();
    }
}
