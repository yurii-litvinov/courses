using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Protocols;
using Thrift.Transports.Client;

namespace gen_netcore
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var phone = new PhoneSvc.Client(
                new TBinaryProtocol(
                    new TSocketClientTransport(IPAddress.Loopback, 8888)));

            await phone.OpenTransportAsync(CancellationToken.None);
            var allPhones = await phone.findAllAsync(CancellationToken.None);

            foreach (var result in allPhones)
            {
                Console.WriteLine(result);
            }
        }
    }
}
