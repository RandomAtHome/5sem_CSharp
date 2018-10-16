using System.Collections.Generic;

namespace lab1_v4
{
    class ResearcherList
    {
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
