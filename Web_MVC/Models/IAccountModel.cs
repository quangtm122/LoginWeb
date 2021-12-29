namespace Web_MVC.Models
{
    public interface IAccountModel
    {
        User CheckLogin(string userName, string passWord);
    }
}