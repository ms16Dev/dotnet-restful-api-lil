using Microsoft.Build.Evaluation;
using System.Collections.ObjectModel;

namespace LiL.TimeTracking.Models;

public class Employee 
{
    public int Id  { get; set; }
    public string Name  { get; set; }

    public DateOnly StartDate { get; set; }

    public virtual Collection<Project> Projects {get;set;}

}