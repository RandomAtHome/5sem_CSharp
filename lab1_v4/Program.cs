using System;

namespace lab1_v4
{
    public enum ProjectType { Applied, Fundamental };
    class Program
    {
        static void Main(string[] args)
        {
            ResearcherList researcherList = new ResearcherList();
            researcherList.AddDefaults();
            System.Console.WriteLine(researcherList);
            System.Console.WriteLine();
            System.Console.WriteLine(researcherList.EarliestWWEDate);
            System.Console.ReadKey();
            //TODO: Complete third assignment
        }
    }
}
