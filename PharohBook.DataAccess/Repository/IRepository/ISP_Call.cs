﻿using Dapper;
using EO.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharohBooks.DataAccess.Repository.IRepository
{
    interface ISP_Call
    {
        T Single<T>(string proceduraName, DynamicParameters param = null);

        void Execute(string procedureName, DynamicParameters param = null);

        T OneRecord<T>(string procedureName, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedureName, DynamicParameters param = null);

        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1, T2>(string procedureName, DynamicParameters param = null);
    }
}
