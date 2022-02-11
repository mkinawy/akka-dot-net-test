namespace AkkaTest.Messages;

public class LoginUserSuccessMessage
{
    public string Email { get; }

    public static LoginUserSuccessMessage Instance(string email) => new(email);

    private LoginUserSuccessMessage(string email)
    {
        Email = email;
    }
}