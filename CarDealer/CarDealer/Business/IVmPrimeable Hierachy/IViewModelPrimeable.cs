using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business
{
    public interface IViewModelPrimeable<T> where T: new()
    {
        Response<T> PrimeViewModel(Request<T> inRequest);
    }
}
