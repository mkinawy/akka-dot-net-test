// See https://aka.ms/new-console-template for more information

using Akka.Actor;
using AkkaTest.Actors;
using AkkaTest.Messages;

Console.WriteLine("Hello, World!");


// root / Actor Basha
using var system = ActorSystem.Create("root");

var usersManagerActor = system.ActorOf<UsersManagerActor>("users-manager");

usersManagerActor.Tell(LoginUserMessage.Instance("correct@email.com", "12345678"));
usersManagerActor.Tell(LoginUserMessage.Instance("incorrect@email.com", "888555"));

Console.ReadKey();
