namespace Module_16.Users;

public interface IUserRepository
{
    IEnumerable<User> FindAll();
}