namespace MVCX.Model;

public interface ILoginViewModel
{
    string UserName { get; set; }
    string Password { get; set; }

    public static ILoginViewModel CreateOne(string name, string pass) => new LoginViewModel(name, pass);
}
