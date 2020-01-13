namespace RevoPay.NET
{
    public interface IRequest<T>
    {
        string EndPoint { get; }

        string PaypointID { get; }

        object RequestParameters { get; }

        IResponse<T> Response { get; set; }
    }
}
