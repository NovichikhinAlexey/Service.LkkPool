using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;
using Service.LkkPool.Grpc;

namespace Service.LkkPool.Client
{
    [UsedImplicitly]
    public class LkkPoolClientFactory: MyGrpcClientFactory
    {
        public LkkPoolClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }

        public IHelloService GetHelloService() => CreateGrpcService<IHelloService>();
    }
}
