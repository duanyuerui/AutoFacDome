using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Service
{
    public class BaseService<T> where T : class, new()
    {
        public string Add()
        {
            return "这是BaseService的添加方法";
        }

        public string Update()
        {
            return "这是BaseService的更新方法";
        }
    }
}
