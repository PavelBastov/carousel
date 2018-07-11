using Mono.Unix;
using Mono.Unix.Native;
using Nancy.Hosting.Self;
using System;

namespace server
{
    class Program
    {
        private static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            var uri = "http://localhost:8888";
            Logger.Info("Starting server on {0}", uri);

            var host = new NancyHost(new Uri(uri));
            host.Start();

            if (Type.GetType("Mono.Runtime") != null)
            {
                UnixSignal.WaitAny(new[]
                {
                    new UnixSignal(Signum.SIGINT),
                    new UnixSignal(Signum.SIGTERM),
                    new UnixSignal(Signum.SIGQUIT),
                    new UnixSignal(Signum.SIGHUP)
                });
            }
            else
            {
                Console.ReadLine();
            }

            Logger.Info("Stopping server...");
            host.Stop();

            NLog.LogManager.Shutdown();
        }
    }
}
