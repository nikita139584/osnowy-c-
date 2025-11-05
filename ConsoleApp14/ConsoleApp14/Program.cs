class Student // CLASS !!!
{
    private string last_name = "Stashko";
    private string name = "Nikita";
    private string patronymic = "Sehrijovich";
    private int date_of_birth = 28092010;
    private string home_address = "Sadovaja 3";
    private long phone_number = 380123456789;

    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return name;
    }


    public void SetLast_name(string last_name)
    {
        this.last_name = last_name;
    }
    public string GetLast_name()
    {
        return last_name;
    }


    public void SetPatronymic(string patronymic)
    {
        this.patronymic = patronymic;
    }
    public string GetPatronymic()
    {
        return patronymic;
    }


    public void SetDate_of_birth(int date_of_birth)
    {
        this.date_of_birth = date_of_birth;
    }
    public int GetDate_of_birth()
    {
        return date_of_birth;
    }


    public void SetHome_address(string home_address)
    {
        this.home_address = home_address;
    }
    public string GetHome_address()
    {
        return home_address;
    }


    public void SetPhone_number(long phone_number)
    {
        this.phone_number = phone_number;
    }
    public long GetPhone_number()
    {
        return phone_number;
    }
    public static void Print(in Student student)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(student.GetName());
        Console.WriteLine(student.GetLast_name());
        Console.WriteLine(student.GetPatronymic());
        Console.WriteLine(student.GetDate_of_birth());
        Console.WriteLine(student.GetHome_address());
        Console.WriteLine(student.GetPhone_number());

        int[] credits = new int[3];
        int[] coursework = new int[3];
        int[] exams = new int[3];
        credits[0] = 3;
        credits[1] = 12;
        credits[2] = 6;


        coursework[0] = 10;
        coursework[1] = 8;
        coursework[2] = 9;


        exams[0] = 9;
        exams[1] = 10;
        exams[2] = 6;

        Console.WriteLine("Оцінки за заліки:");
        Console.WriteLine(credits[0]);
        Console.WriteLine(credits[1]);
        Console.WriteLine(credits[2]);


        Console.WriteLine("Оцінки за курсові роботи");
        Console.WriteLine(coursework[0]);
        Console.WriteLine(coursework[1]);
        Console.WriteLine(coursework[2]);


        Console.WriteLine("Оцінки за іспити");
        Console.WriteLine(exams[0]);
        Console.WriteLine(exams[1]);
        Console.WriteLine(exams[2]);


    }

}
class Program
{
    static void Main()
    {
        Student s = new Student();
        Student.Print(in s);
    }
}