namespace Models
{
    public class Request<T> where T : new()
    {
        public string Message { get; set; }
        public T Data { get; set; }

        public Request()
        {
            Data = new T();
        }
    }
}

