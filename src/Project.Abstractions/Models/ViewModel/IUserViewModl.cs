using Sample.Abstractions.Models.Model;

namespace Sample.Abstractions.Models.ViewModel
{
    public interface IUserViewModel
    {
        string Habit { get; set; }
    }



    public class UserViewModel : Users , IUserViewModel
    {
        public string Habit { get; set; }
    }
}
