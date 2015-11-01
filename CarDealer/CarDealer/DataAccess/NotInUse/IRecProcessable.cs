using System.Collections.Generic;
using Models;

namespace DataAccess
{
    public interface IRecProcessable<T> where T : new()
    {
        Response<T> Process (Request<T> inRequest);
    }
}