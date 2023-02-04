using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("http://localhost:5054/");
var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(
    new HelloRequest { Name = "World" });

Console.WriteLine(response.Message);