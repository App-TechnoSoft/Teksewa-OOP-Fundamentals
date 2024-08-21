using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppForFundamentals;
internal class ParallelAndAsync
{
    // Parallel Programming:
    // Ability to compute our tasks simulteneously in multiple CPU cores
    // .NET - TPL - Task Parallel Library
    // Task, Task<> class

    int[] numbers = [234, 23424, 35355, 4646, 23424, 4664, 234214141, 6464757, 234, 23424, 35355, 4646, 23424, 4664, 234214141, 6464757];

    public void ComputeSequential()
    {
        Console.WriteLine("Computing in sequence:");
        foreach (int number in numbers)
            ComputeIfPrime(number);
    }

    public void ComputeParallel()
    {
        Console.WriteLine("Computing in parallel:");
        Parallel.ForEach(numbers, x =>        {
            ComputeIfPrime(x);
        });
    }

    private void ComputeIfPrime(int num)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Computing {num}... Done");
    }

    // Asynchronous Programming
    // Doing things in background in non-blocking way
    // async and await
    public async Task DoTask1()
    {
        await Task.Delay(1000);
    }

    public async Task<string> DoTask2()
    {
        HttpClient client = new HttpClient();
        var homePageContent = await client.GetStringAsync("https://sherlock-holm.es/stories/plain-text/lstb.txt");
        homePageContent = homePageContent.Replace("\n", "");

        Regex regex = new Regex("^[.?!] \\w*[.?!]$");
        return homePageContent;
    }
}
