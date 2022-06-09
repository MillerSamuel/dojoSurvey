namespace DojoSurvey.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;


public class User
{
    [Required(ErrorMessage ="Please Enter A Name")]
    [MinLength(2)]
    public string Name{get;set;}

    [Required]
    public string Location{get;set;}

    [Required]
    public string Fav {get;set;}

    public string? Comment{get;set;}
}