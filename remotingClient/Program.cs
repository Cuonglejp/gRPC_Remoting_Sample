using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingLibrary.Interfaces;

var clientChannel = new TcpChannel();
ChannelServices.RegisterChannel(clientChannel, true);
var greetingService = (IGreetingService)Activator.GetObject(
    typeof(IGreetingService),
    "tcp://localhost:8080/GreetingService");

string name = Console.ReadLine(); 
var response = greetingService.GetGreeting(name);
Console.WriteLine(response); // Should print "Hello, Alice!"