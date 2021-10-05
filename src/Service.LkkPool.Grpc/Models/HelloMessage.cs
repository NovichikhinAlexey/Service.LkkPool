using System.Runtime.Serialization;
using Service.LkkPool.Domain.Models;

namespace Service.LkkPool.Grpc.Models
{
    [DataContract]
    public class HelloMessage : IHelloMessage
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }
    }
}