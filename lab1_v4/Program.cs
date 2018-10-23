using System;

namespace lab1_v4
{
    public enum ProjectType { Applied, Fundamental };
    class Program
    {
        static void Main(string[] args)
        {
            //defaults list showcase
            System.Console.WriteLine("Showcase with the Default List");
            ResearcherList researcherList = new ResearcherList();
            researcherList.AddDefaults();
            System.Console.WriteLine(researcherList);
            System.Console.WriteLine();
            System.Console.WriteLine("(1) Get earliest worldwide project ending");
            System.Console.WriteLine(researcherList.EarliestWWEDate);
            System.Console.WriteLine();
            System.Console.WriteLine("(2) Get reference for the earliest project");
            System.Console.WriteLine(researcherList.EarliestProj);
            System.Console.WriteLine("\n");
            System.Console.ReadKey();
            //empty list showcase
            System.Console.WriteLine("The following list will be empty!");
            ResearcherList emptyList = new ResearcherList();
            System.Console.WriteLine(emptyList);
            System.Console.WriteLine();
            System.Console.WriteLine("(1) Get earliest worldwide project ending");
            System.Console.WriteLine(emptyList.EarliestWWEDate);
            System.Console.WriteLine();
            System.Console.WriteLine("(2) Check if the property returns null when all lists are empty");
            System.Console.WriteLine(emptyList.EarliestProj is null);
            System.Console.ReadKey();
        }
    }
}
