using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_v4
{
    public enum ProjectType { Applied, Fundamental };
    class Program
    {
        static void Main(string[] args)
        {
            Researcher researcher = new Researcher("Petrov", "Ivan", 1.2);
            researcher.AddProject(new LocalProject("Loc1"), new InternationalProject("Int1", ProjectType.Fundamental, new DateTime(), "Russia", 1), new InternationalProject("Int2", ProjectType.Applied, new DateTime(), "Russia2", 3));
            /*Console.WriteLine(researcher.ToString());
            Project project1 = new Project("Physics", ProjectType.Applied);
            Project project2 = new Project("Physics", ProjectType.Applied);
            Project project3 = null;
            Console.WriteLine(project1 == project2);
            Console.WriteLine(project1.Equals(project2));
            Console.WriteLine(project1.Equals(project3));
            Console.WriteLine(project3 == project1);
            Console.WriteLine(project3 == null);*/
            foreach (Project i in researcher)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
            foreach (Project i in researcher.GetIntBigProjects())
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
