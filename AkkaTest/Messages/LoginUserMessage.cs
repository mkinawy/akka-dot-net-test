namespace AkkaTest.Messages;

public class LoginUserMessage
{
    public string Email { get; }
    public string Password { get; }

    public static LoginUserMessage Instance(string email, string password) => new(email, password);

    private LoginUserMessage(string email, string password)
    {
        Email = email;
        Password = password;
    }
}