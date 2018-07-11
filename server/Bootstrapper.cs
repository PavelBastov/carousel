using Autofac;
using Nancy;
using Nancy.Bootstrappers.Autofac;
using Nancy.Conventions;
using server.Pictures;

namespace server
{
    public class Bootstrapper : AutofacNancyBootstrapper
    {
        protected override void ConfigureRequestContainer(ILifetimeScope container, NancyContext context)
        {
            container.Update(builder => builder.RegisterType<LocalFilePictureProvider>().As<IPictureProvider>());
        }

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/", "static"));
            base.ConfigureConventions(nancyConventions);
        }
    }
}
