namespace OOPExamples
{
  public class Student : IDisposable
  {
    public int SchoolId { get { return _schoolId; } set { _schoolId = value; } }
    private int _schoolId;
    public string? FirstName { get { return _firstName; } set { _firstName = value; } }
    private string? _firstName;
    public string? LastName { get { return _lastName; } set { _lastName = value; } }
    private string? _lastName;
    public int Age
    {
      get { return _age; }
      set
      {
        if (value < 0) _age = 0;
        else _age = value;
      }
    }
    private int _age;

    public Student()
    {
      Console.WriteLine("Default constructor called!");
    }

    ~Student()
    {
      Console.WriteLine("Destructor called!");
    }

    public Student(int schooldId, string firstName, string lastName)
    {
      SchoolId = schooldId;
      FirstName = firstName;
      LastName = lastName;
    }

    public void Print()
    {
      Console.WriteLine($"Student: {SchoolId} {FirstName} {LastName}");
    }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}
