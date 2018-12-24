using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAD.IDal;
using MAD.Models;

namespace MAD.Dal
{
    public class BaseDal<T> : IBaseDal<T> where T : class, new()
    {
        public DbContext db = DbFactory.GetContext();

        public string Add()
        {
            return "这是BaseDal的添加方法";
        }
        public string Update()
        {
            return "这是BaseDal的更新方法";
        }
    }
}
