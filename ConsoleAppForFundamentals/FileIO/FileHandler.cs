using ABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForFundamentals.FileIO;
internal class FileHandler
{
    public async Task<List<Person>> ReadFileAsync()
    {
        string filePath = @"D:\AppSoft\Pro Training\Teksewa-OOP-Fundamentals\ConsoleAppForFundamentals\FileIO\Files\Employees.csv";
        var fileContent = await File.ReadAllTextAsync(filePath);

        // Display name and dob of all people in employees.csv
        var lines = fileContent.Split(["\n", "\r"], StringSplitOptions.RemoveEmptyEntries);

        var employees = new List<Person>();
        foreach ( var line in lines.Skip(1) )
        {
            var data = line.Split(",", StringSplitOptions.RemoveEmptyEntries);

            var name = data[0];
            DateTime.TryParse(data[1], out DateTime d);
            var dob = d;
            var nid = long.Parse(data[2]);

            var employee = new Person(name, dob, nid);
            employees.Add(employee);
        }

        Console.WriteLine("=============================================");
        foreach (var emp in employees)
        {
            emp.PrintDetails();
            Console.WriteLine();
        }
        Console.WriteLine("=============================================");
        
        return employees;
    }

    public async Task WriteFileAsync()
    {
        string filePath = @"D:\AppSoft\Pro Training\Teksewa-OOP-Fundamentals\ConsoleAppForFundamentals\FileIO\Files\People.txt";
        await File.WriteAllTextAsync(filePath, "This file contains people information\nThis file contains people information");
    }

    public async Task WriteEmployeesToFileAsync(List<Person> employees)
    {
        string filePath = @"D:\AppSoft\Pro Training\Teksewa-OOP-Fundamentals\ConsoleAppForFundamentals\FileIO\Files\Employees.txt";

        var employeesCollection = employees.Select(Person.PrintDetails);

        await File.WriteAllLinesAsync(filePath, employeesCollection);
    }

    public void GetFileInfo()
    {
        string filePath = @"D:\AppSoft\Pro Training\Teksewa-OOP-Fundamentals\ConsoleAppForFundamentals\FileIO\Files\People.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        Console.WriteLine(fileInfo.FullName);
        Console.WriteLine(fileInfo.CreationTime);
        Console.WriteLine(fileInfo.LastAccessTime);
        Console.WriteLine($"{fileInfo.Length / 1024: F2} KB");
    }

}
