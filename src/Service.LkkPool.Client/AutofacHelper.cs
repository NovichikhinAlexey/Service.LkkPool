using Autofac;
using Service.LkkPool.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.LkkPool.Client
{
    public static class AutofacHelper
    {
        public static void RegisterLkkPoolClient(this ContainerBuilder builder, string grpcServiceUrl)
        {
            var factory = new LkkPoolClientFactory(grpcServiceUrl);

            builder.RegisterInstance(factory.GetHelloService()).As<IHelloService>().SingleInstance();
        }
    }
}
