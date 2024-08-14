namespace ConsoleAppForFundamentals;
internal class Linq         // Language Integrated Query
{
    static double[] marks = [34.5, 67.1, 80.5, 65.8, 70.5, 45.0, 68, 20.5];    // "34.50", "67.10"

    static List<Student> students = [
            new("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
            new("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
            new("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
            new("Suneer Bista", new DateTime(2000, 6, 10), "Cenral TU", "BIT"),
            new("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
            new("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC")
    ];

    // Get all marks which surpass passmark 40

    public static void Query()
    {
        // Imperative
        List<double> passMarks = [];
        foreach (var mark in marks)
        {
            if (mark > 40)
            {
                passMarks.Add(mark);
            }
        }

        // Declarative
        var passMarks1 = marks.Where(mark => mark > 40);    // Filter

        var result = marks.Select(x => x.ToString("F2"));   // Projection


        // Get all passmarks converted to nearest integer
        // Method syntax
        var marksToPrint = marks.Where(mark => mark > 40).Select(x => Math.Round(x));

        // Expression Syntax
        marksToPrint = from mark in marks
                       where mark > 40
                       select Math.Round(mark);


        // Get all employees who are born after 2000 AD
        var youngerStudents = students.Where(x => x.dob.Year > 2000);

        // Get employee name with their ages and order by age
        var emps = students
            .Select(x => new { Name = x.name, Age = x.CalculateAge() })
            .OrderBy(x => x.Age.Item2);

        foreach (var item in emps)
        {
            Console.WriteLine($"{item.Name}\t{item.Age.Item1}");
        }
    }
}
