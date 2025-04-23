namespace Management_App;

public class Patient
{
    private int _id = 1;

    public int Id
    {
        get
        {
            return _id;

        }
        set
        {
            _id = value;

        }
    }

    public string name;
    public string surname;
    public int age;
    public Gender gender;

    public Patient(string name, string surname, int age, Gender gender)
    {
        this.Id = _id++;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.gender = gender;

    }
}


public class Doctor
{
    public string id;

    public string name;
    public string surname;
    public int age;
    public int ExperienceYear;
    public Gender gender;
    public Department departmentenum;

}

public class Appointment
{
    public string Patientld { get; set; }
    public string Doctorld { get; set; }
    public DataTime DataTime { get; set; }


}





