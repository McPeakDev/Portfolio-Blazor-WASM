namespace portfolio.Models;

public class Owner {
    public string? avatar_url { get; set; }

}

public class Project {
    
    public int Id { get; set; } 

    public Owner? owner { get; set; }
    
    public string? name { get; set; } 

    public string? language { get; set; } 

    public DateTime pushed_at { get; set; } 

    public string? description { get; set; }

    public string? html_url { get; set; }

}
