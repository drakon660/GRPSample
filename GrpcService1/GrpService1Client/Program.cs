// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcService1;

Console.WriteLine("Hello, World!");

var channel = GrpcChannel.ForAddress("https://drakon-grpc-1.azurewebsites.net");
//var channel = GrpcChannel.ForAddress("https://localhost:8585");

var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();