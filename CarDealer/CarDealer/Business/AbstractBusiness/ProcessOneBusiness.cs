using System;
using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public abstract class ProcessOneBusiness<T> where T : new()
    {
        protected ProcessOneRepo<T> _repo;
        protected Response<T> _response;


        protected ProcessOneBusiness()
        {
            
        }

        protected ProcessOneBusiness(ProcessOneRepo<T> inRepo, Response<T> inNewResponse)
        {
            this._repo = inRepo;
            this._response = inNewResponse;
        }

        public abstract Response<T> Process(Request<T> inRequest);
    }
}