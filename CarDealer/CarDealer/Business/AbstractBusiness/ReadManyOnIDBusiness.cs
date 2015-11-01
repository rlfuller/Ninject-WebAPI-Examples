using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public abstract class ReadManyOnIDBusiness<T> where T : new()
    {
        private readonly ReadOnIDRepo<T> _repo;
        private Response<List<T>> _response;


        protected ReadManyOnIDBusiness(ReadOnIDRepo<T> inRepo, Response<List<T>> inNewResponse)
        {
            this._repo = inRepo;
            this._response = inNewResponse;
        }

        public virtual Response<List<T>> ReadManyOnID(int inID)
        {

            _response = _repo.ReadManyByID(inID);

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