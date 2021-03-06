﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDA.IService
{
    public interface IBaseService<T> where T : class, new()
    {
        string Add();

        string Update();
    }
}
