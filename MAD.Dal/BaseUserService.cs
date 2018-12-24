using System.Collections.Generic;
using System.Linq;
using MAD.IDal;
using MAD.Models;

namespace MAD.Dal
{
    public class BaseUserDal : BaseDal<BaseUser>, IBaseUserDal
    {
        public string Delete()
        {
            return "这是BaseUser的Delete方法";
        }

        public IQueryable<BaseUser> Select()
        {
            return db.Set<BaseUser>().Where(x => x.Id > 0);
        }

        public string Dtl()
        {
            return "这是BaseUser的查询详情方法";
        }

    }
}