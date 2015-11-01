using System.Collections.Generic;
using Models;

namespace DataAccess
{
    public interface IAllRecordsReadable<T> where T : new()
    {
        Response<List<T>> Read();
    }
}