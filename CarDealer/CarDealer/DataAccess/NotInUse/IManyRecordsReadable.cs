using System.Collections.Generic;
using Models;

namespace DataAccess
{
    public interface IManyRecordsReadable<T> where T : new()
    {
        Response<List<T>> Read(Request<T> inRequest );
    }
}