
class StudentProfile
{
    private string name;
    private int age;

    private int marks;

    public int StudentID{get; set;}
    private string password;

    public string Name{
        get{  return name; }
        set
        {
            if (value!=null)
            {
                name=value;
            }
        }
    }
    public int Age
    {
        get{return age;}
        set
        {
            if (value > 0)
            {
                age=value;
            }
            else
            {
                Console.WriteLine("age cannot be zero");
            }
        }
    }

    public int Marks
    {
        get{return marks;}
        set
        {
            if(value>0 && value <= 100)
            {
                marks=value;
            }
        }
    }

    public string Result
    {
        get{
            return (marks >= 40)? "Pass":"Fail";
        }
    }

    public string Password
    {
        set
        {
            if (value.Length >= 6)
            {
                password=value;
            }
        }
    }

    public int RegistrationNo{  get; private set;}
    public int Year{ get; init;}
    public int Percentage =>(marks/100)*100;

    public StudentProfile(int reg)
    {
        RegistrationNo=reg;
    }


}



// class EmployeeDirectory
// {
//     Dictionary<int, string> employees = new Dictionary<int, string>();

//     public virtual string this[int id]
//     {
//         get { return employees[id]; }
//         set { employees[id] = value; }
//     }

//     public string this[string name]
//     {
//         get
//         {
//             return employees.FirstOrDefault(e => e.Value == name).Value;
//         }
//     }
// }

// class employee:EmployeeDirectory
// {

//     public string Override this[int id]
//     {
//         get { return employees[id]; }
//         set { employees[id] = value; }
//     }
    
// }