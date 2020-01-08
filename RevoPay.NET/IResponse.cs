namespace RevoPay.NET
{
    public interface IResponse<T>
    {
        public string Response { get; set; }

        public string ResponseTxt { get; set; }

        public string Start { get; set; }

        public string Limit { get; set; }

        public T Records { get; set; }
    }
}
