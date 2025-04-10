namespace Task_Revise.Model;

public class User : Human
{


    #region Hint
    //public string username;
    //public string password;

    //public User(string name, string surname, string username, string password) : base(name, surname)
    //{

    //    this.username = username;
    //    this.password = password;
    //}
    #endregion

    public string username;
    public string Username
    {
        get { return username; }
        set
        {
            if (value.Length > 6 && value.Length <= 25)
            {
                username = value;
            }
        }
    }

    public string password;

    public string Password
    {
        get { return password; }
        set
        {
            if (value.Length > 8 && value.Length <= 25)
            {
                password = value;
            }
        }
    }



    public User(string name, string surname, string username)
    {
        this.name = name;
        this.surname = surname;


    }

}
