using Akka.Actor;
using Akka.Event;
using AkkaTest.Messages;

namespace AkkaTest.Actors;

public class UsersManagerActor : ReceiveActor
{
    private readonly ILoggingAdapter _logger = Context.GetLogger();

    public UsersManagerActor()
    {
        Receive<LoginUserMessage>(login =>
        {
            var loginUserActor = Context.ActorOf<UserLoginActor>();
            loginUserActor.Tell(login);
        });

        Receive<LoginUserSuccessMessage>(success =>
        {
            _logger.Info($"{success.Email} logged in successfully!");
        });

        Receive<LoginUserFailureMessage>(failure =>
        {
            _logger.Info($"{failure.Email} failed to login :(");
        });
    }
}