using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1_v4
{
    class ResearcherList
    {
        public DateTime EarliestWWEDate
        {
            get
            {
                var query =  from researcher in researchers
                             from project in researcher.projects
                             where project is InternationalProject
                             orderby project.date ascending
                             select project.date;
                return query.Count() != 0 ? query.First() : default(DateTime);
            }
        }

        public Project EarliestProj
        {
            get
            {
                //TODO: Using LINQ find earliest ending project
                var query = from researcher in researchers
                            from project in researcher.projects
                            orderby project.date ascending
                            select project;
                return query.Count() != 0 ? query.First() : null;
                throw new NotImplementedException();
            }
        }

        public IEnumerable<LocalProject> LProjectsDecreasingDuration
        {
            get
            {
                //TODO: third functionality
                throw new NotImplementedException();
            }
        } 

        public IEnumerable<IGrouping<int, InternationalProject>> GroupByParticipantsCount
        {
            get
            {
                //TODO: fourth functionality
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Project> UniqueProjects
        {
            get
            {
                //TODO: fifth functionality
                throw new NotImplementedException();
            }
        }

        private List<Researcher> researchers;
        public ResearcherList(List<Researcher> researchers = null)
        {
            if (researchers == null)
                researchers = new List<Researcher>();

            this.researchers = researchers;
        }
        public void AddDefaults()
        {
            Researcher first = new Researcher("Chukharev", "Fedor", 2.5);
            first.AddProject(new LocalProject("Hometask", ProjectType.Applied, new DateTime(2018, 11, 6), 1, false));
            first.AddProject(new InternationalProject("Feunman Integrals", ProjectType.Applied, new DateTime(2019, 2, 19), "Russia", 2));
            researchers.Add(first);

            Researcher second = new Researcher("Polyakov", "Dimitri", 0.1);
            second.AddProject(new InternationalProject("Federal Laws", ProjectType.Applied, new DateTime(2020, 1, 1), "Russia", 7));
            second.AddProject(new InternationalProject("Judgement System", ProjectType.Fundamental, new DateTime(2022, 1, 1), "Russia", 1));
            researchers.Add(second);

            Researcher third = new Researcher("Fionov", "Alexey", 2);
            third.AddProject(new LocalProject("Japanese lessons", ProjectType.Applied, new DateTime(2018, 10, 30), 1, false));
            researchers.Add(third);

            Researcher slacker = new Researcher("Dou", "John", 0.0);
            researchers.Add(slacker);
            //TODO: Add minimal set of researchers viable for testing
        }
        public override string ToString()
        {
            if (researchers.Count == 0)
            {
                return "List is empty!";
            }
            string result = "";
            string delim = "\n";
            int counter = 1;
            foreach (Researcher researcher in researchers)
            {
                result += counter +": " + researcher + delim;
                counter++;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return researchers.GetHashCode();
        }
    }
}
