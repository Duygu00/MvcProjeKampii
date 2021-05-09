﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
 public   interface IRepository<T>
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);

        void update(T P);
        List<T> List(Expression<Func<T, bool>> filter );
       
            

    }
}