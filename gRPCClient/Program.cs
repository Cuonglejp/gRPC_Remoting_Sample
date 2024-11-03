using Grpc.Net.Client;
using GrpcGreeting;

// Connect to the gRPC server running on HTTPS
var channel = GrpcChannel.ForAddress("https://localhost:5001"); // Use HTTPS
var client = new GreetingService.GreetingServiceClient(channel);

// Prepare the request
string name = Console.ReadLine()??"";
var request = new GreetingRequest { Name = name };

// Call the service method
var response = await client.GetGreetingAsync(request);

// Display the response
Console.WriteLine(response.Message); // Should print "Hello, Alice!"
