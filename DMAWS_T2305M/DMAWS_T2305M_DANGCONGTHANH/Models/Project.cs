namespace DMAWS_T2305M_DANGCONGTHANH.Models;

public class Project
{
    public int ProjectId { get; set; }

    
    public string ProjectName { get; set; }

    
    public DateTime ProjectStartDate { get; set; }

    
    public DateTime? ProjectEndDate { get; set; }

    
    public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
}