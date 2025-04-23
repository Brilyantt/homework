namespace Management_App;

public static class DBContext
{
    static Patient[] patients;

    static Doctor[] doctors;

    static Appointment[] appointments;

    static DBContext()
    {
        patients = new Patient[0];
        doctors = new Doctor[0];
        appointments = new Appointment[0];
    }


    public static void AddNewPatient(Patient patient)
    {
        Array.Resize(ref patients, patients.Length + 1);
        patients[patients.Length - 1] = patient;

    }
    public static void AddNewDoctor(Doctor doctor)
    {
        Array.Resize(ref doctors, doctors.Length + 1);
        doctors[doctors.Length - 1] = doctor;

    }
    public static void AddNewAppointment(Appointment appointment)
    {
        Array.Resize(ref appointments, appointments.Length + 1);
        appointments[appointments.Length - 1] = appointment;

    }

    public static Patient[] GetPatient()
    {
        foreach (Patient item in patients)
        {
            Console.WriteLine($"{item.name} {item.surname}, {item.Id}, {item.gender}, {item.age}");
        }
        return patients;
    }

    public static Doctor[] GetDoctor()
    {
        return doctors;
    }

    public static Appointment[] GetAppointment()
    {
        return appointments;
    }

}
