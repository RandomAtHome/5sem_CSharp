using System;

public class Project
{
    enum ProjectType {Applied, Fundamental}
    public string theme { get; set; }
    public ProjectType type { get; set; }
    public DateTime date { get; set; }
    public Project(string theme, ProjectType type, DateTime date) {

	}
}
