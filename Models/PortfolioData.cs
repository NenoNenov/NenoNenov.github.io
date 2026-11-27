namespace Portfolio.Models;

// All site content lives in wwwroot/data/portfolio.json.
// To add a project or certificate, edit that file only.
public class PortfolioData
{
    public Profile Profile { get; set; } = new();
    public List<Technology> Technologies { get; set; } = new();
    public List<SkillGroup> Skills { get; set; } = new();
    public List<Experience> Experience { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<Certificate> Certificates { get; set; } = new();
    public List<Education> Education { get; set; } = new();
}

public class Profile
{
    public string Name { get; set; } = "";
    public string Title { get; set; } = "";
    public string Tagline { get; set; } = "";
    public List<string> About { get; set; } = new();
    public string Location { get; set; } = "";
    public string Email { get; set; } = "";
    public string LinkedIn { get; set; } = "";
    public string GitHub { get; set; } = "";
    public bool OpenToWork { get; set; }
    public string OpenToWorkText { get; set; } = "";
}

public class SkillGroup
{
    public string Name { get; set; } = "";
    public List<string> Items { get; set; } = new();
}

public class Experience
{
    public string Role { get; set; } = "";
    public string Company { get; set; } = "";
    public string Period { get; set; } = "";
    public string Location { get; set; } = "";
    public List<string> Highlights { get; set; } = new();
}

public class Project
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<string> Tags { get; set; } = new();
    public string? LiveUrl { get; set; }
    public string? RepoUrl { get; set; }
    public string? Image { get; set; }
    public string? Status { get; set; }
}

public class Certificate
{
    public string Title { get; set; } = "";
    public string Issuer { get; set; } = "";
    public string Date { get; set; } = "";
    public string? Url { get; set; }
}

public class Education
{
    public string Degree { get; set; } = "";
    public string School { get; set; } = "";
    public string Period { get; set; } = "";
}

public class Technology
{
    public string Name { get; set; } = "";
    public string Icon { get; set; } = "";
}
