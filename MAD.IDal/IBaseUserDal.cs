using System.Linq;
using MAD.Models;

namespace MAD.IDal
{
    public interface IBaseUserDal : IBaseDal<BaseUser>
    {
        string Delete();

        IQueryable<BaseUser> Select();

        string Dtl();

    }
}