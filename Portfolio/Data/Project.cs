using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data;

public class Project
{
    [Key,Required]
    public Guid Id { get; set; }

    [Required]
    public string Name{ get; set;}
    
    [Required]
    public string Description{ get; set; }

    [Required]
    public string[] Images{ get; set; }
    
    [Required]
    public string Summary{ get;set; }
    
    [Required]
    public string Contribution{ get; set; }
    
    [Required]
    public string TecnicalInfo{ get;set; }
    
    
    public string ExtraInfo { get; set; } 
}