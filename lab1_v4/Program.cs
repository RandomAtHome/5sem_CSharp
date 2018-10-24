using System;

namespace lab1_v4
{
    public enum ProjectType { Applied, Fundamental };
    class Program
    {
        static void Main(string[] args)
        {
            //defaults list showcase
            Console.WriteLine("Showcase with the Default List");
            ResearcherList researcherList = new ResearcherList();
            researcherList.AddDefaults();
            Console.WriteLine(researcherList);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("(1) Get earliest worldwide project ending");
            Console.WriteLine(researcherList.EarliestWWEDate);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("(2) Get reference for the earliest project");
            Console.WriteLine(researcherList.EarliestProj);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("(3) Get enumerable in descending order for all local projects");
            foreach (LocalProject localProject in researcherList.LProjectsDecreasingDuration)
                Console.WriteLine(localProject + "\n");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("(4) Get enumerable grouping for international projects by participants count");
            foreach (var group in researcherList.GroupByParticipantsCount)
            {
                Console.WriteLine("Participant count: " + group.Key + "\n");
                foreach (var project in group)
                    Console.WriteLine(project + "\n");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("(5) Get enumerable for projects appearing in different lists");
            foreach (Project project in researcherList.RepeatingProjects)             
                    Console.WriteLine(project + "\n");
            Console.WriteLine("\n");
            Console.ReadKey();
            //empty list showcase
            Console.WriteLine("The following list will be empty!");
            ResearcherList emptyList = new ResearcherList();
            Console.WriteLine(emptyList);
            Console.WriteLine("(1) Get earliest worldwide project ending");
            Console.WriteLine(emptyList.EarliestWWEDate);
            Console.WriteLine("(2) Check if the property returns null when all lists are empty");
            Console.WriteLine(emptyList.EarliestProj is null);
            Console.WriteLine("(3) Get enumerable in descending order for all local projects");
            foreach (LocalProject localProject in emptyList.LProjectsDecreasingDuration)
                Console.WriteLine(localProject);
            Console.WriteLine("(4) Get enumerable grouping for international projects by participants count");
            foreach (var group in emptyList.GroupByParticipantsCount)
            {
                Console.WriteLine("Participant count: " + group.Key + "\n");
                foreach (var project in group)
                    Console.WriteLine(project);
                Console.WriteLine();
            }
            Console.WriteLine("(5) Get enumerable for projects appearing in different lists");
            foreach (Project project in emptyList.RepeatingProjects)
                Console.WriteLine(project + "\n");
            Console.ReadKey();
        }
    }
}
