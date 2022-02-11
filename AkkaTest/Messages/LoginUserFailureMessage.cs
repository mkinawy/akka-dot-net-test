namespace AkkaTest.Messages;

public class LoginUserFailureMessage
{
    public string Email { get; }

    public static LoginUserFailureMessage Instance(string email) => new(email);

    private LoginUserFailureMessage(string email)
    {
        Email = email;
    }
}