using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedureName, DynamicParameters parameters);

        void Execute(string procedureName, DynamicParameters parameters);

        T OneRecord<T>(string procedureName, DynamicParameters parameters);

        IEnumerable<T> List<T>(string procedureName, DynamicParameters parameters);

        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1,T2>(string procedureName, DynamicParameters parameters);
    }
}
