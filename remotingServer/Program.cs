using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
var serverChannel = new TcpChannel(8080);
ChannelServices.RegisterChannel(serverChannel, true);
RemotingConfiguration.RegisterWellKnownServiceType(
    typeof(GreetingService),
    "GreetingService",
    WellKnownObjectMode.Singleton);

Console.WriteLine("Remoting server is running...");
Console.ReadLine();
