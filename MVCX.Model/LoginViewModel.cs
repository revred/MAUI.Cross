using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;

namespace MVCX.Model;

public class LoginViewModel : MvxViewModel, ILoginViewModel
{
    public static IMvxMessenger Messenger => messenger_!;
    private static IMvxMessenger? messenger_ = FetchMessenger();
    private static IMvxMessenger? FetchMessenger() => null;
    public string UserName { get; set; }
    public string Password { get; set; }

    internal LoginViewModel(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
}