using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public abstract class ReadAllBusiness<T> where T : new()
    {
        private readonly ReadAllRepo<T> _repo;
        private Response<List<T>> _response;


        protected ReadAllBusiness(ReadAllRepo<T> inRepo, Response<List<T>> inNewResponse)
        {
            this._repo = inRepo;
            this._response = inNewResponse;
        }

        public virtual Response<List<T>> ReadAll()
        {
                     
            _response = _repo.ReadAll();

            if (_response.Data.Count == 0)
            {
                _response.Success = false;
                _response.Message = "Nothing here...";
            }
            else
            {
                _response.Success = true;
                _response.Message = "Read sucessful";
            }
                           
            return _response;
        }
    }
}