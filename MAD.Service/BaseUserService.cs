using System.Collections.Generic;
using System.Linq;
using MAD.IDal;
using MAD.Models;
using MDA.IService;

namespace MAD.Service
{
    public class BaseUserService : BaseService<BaseUser>, IBaseUserService
    {
        public IBaseUserDal BaseUserDal { get; set; }
        public string Delete()
        {
            return BaseUserDal.Delete();
        }

        public List<BaseUser> Select()
        {
            return BaseUserDal.Select().ToList();
        }

        public string Dtl()
        {
            return BaseUserDal.Dtl();
        }
    }
}