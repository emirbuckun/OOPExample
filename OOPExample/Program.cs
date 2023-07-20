namespace OOPExamples
{
  class Program
  {
    static void Main()
    {
      Student student1 = new()
      {
        SchoolId = 1,
        FirstName = "Ali",
        LastName = "Mutlu"
      };
      Student student2 = new(2, "Emir", "Büçkün");

      PrintStudent(student1);
      PrintStudent(student2);
    }

    public static void PrintStudent(Student student)
    {
      student.Print();
    }
  }
}
