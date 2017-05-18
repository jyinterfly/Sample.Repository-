namespace Sample.Abstractions.Models.Model
{
    public interface IUser
    {
        int UserID { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
    }

    public class Users : IUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
