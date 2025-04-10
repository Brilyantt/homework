namespace Task_Revise.Model;

public class Human
{

    #region Hint
    //public Human()
    //{

    //}
    //public Human(string name)
    //{
    //    this.name = name;
    //}


    //public Human(string name, string surname):this(name)
    //{
    //    this.surname = surname;
    //}


    //public string name;

    //public string surname;

    //public byte age;





    //public static void ShowFullData() { }

    //public static void GetFullNmae() { }
    #endregion

    public Human()
    {

    }

    public Human(string name)
    {
        this.name = name;
    }

    public Human(string name, string surname)
    {
        this.surname = surname;
    }

    public string name;

    public string surname;

    public byte age;

    private byte Age { get; set; }


    public void ShowFullData() { }

    public void GetFullName() { }
}


