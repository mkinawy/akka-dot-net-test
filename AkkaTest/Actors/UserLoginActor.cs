using Akka.Actor;
using AkkaTest.Messages;

namespace AkkaTest.Actors;

public class UserLoginActor : ReceiveActor
{
    public UserLoginActor()
    {
        Receive<LoginUserMessage>(login =>
        {
            if (login.Email == "correct@email.com" && login.Password == "12345678")
            {
                Context.Sender.Tell(LoginUserSuccessMessage.Instance(login.Email));
            }
            else
            {
                Context.Sender.Tell(LoginUserFailureMessage.Instance(login.Email));
            }
        });
    }
}