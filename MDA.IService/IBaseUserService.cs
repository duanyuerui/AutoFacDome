using System.Collections.Generic;
using MAD.Models;

namespace MDA.IService
{
    public interface IBaseUserService : IBaseService<BaseUser>
    {
        string Delete();

        List<BaseUser> Select();
        string Dtl();
    }
}