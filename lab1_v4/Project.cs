using System;

namespace lab1_v4 {
    public class Project
    {
        public string theme { get; set; }
        public ProjectType type { get; set; }
        public DateTime date { get; set; }

        public Project(string theme = "", ProjectType type = ProjectType.Applied, DateTime date = new DateTime())
        {
            this.theme = theme;
            this.type = type;
            this.date = date;   
	    }

        public override string ToString()
        {
            string delim = "\n";
            return  "Theme: " + theme + delim +
                    "Type: " + type + delim +
                    "Ends on: " + date.ToShortDateString();
        }
        public override int GetHashCode()
        {
            return date.GetHashCode() + theme.GetHashCode() + (int)type;
        }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(obj, null))
                return false;
            return this.date.Equals(((Project)obj).date) && this.theme.Equals(((Project)obj).theme) && this.type.Equals(((Project)obj).type); 
        } 
        public static bool operator ==(Project a, Project b)
        {
            return Object.ReferenceEquals(a, b) || (!Object.ReferenceEquals(a, null) && a.Equals(b));
        }
        public static bool operator !=(Project a, Project b)
        {
            return !(a == b);
        }
    }
}