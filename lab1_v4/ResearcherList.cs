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
                //TODO: Using LINQ find earliest ending worldwide project date
                throw new NotImplementedException();
            }
        }

        public Project EarliestProj
        {
            get
            {
                //TODO: Using LINQ find earliest ending project
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
        ResearcherList(List<Researcher> researchers = null)
        {
            if (researchers == null)
                researchers = new List<Researcher>();

            this.researchers = researchers;
        }
        public void AddDefaults()
        {
            //TODO: Add minimal set of researchers viable for testing
        }
        public override string ToString()
        {
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
