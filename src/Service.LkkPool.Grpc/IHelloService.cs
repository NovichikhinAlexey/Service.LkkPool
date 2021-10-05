using System.ServiceModel;
using System.Threading.Tasks;
using Service.LkkPool.Grpc.Models;

namespace Service.LkkPool.Grpc
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        Task<HelloMessage> SayHelloAsync(HelloRequest request);
    }
}