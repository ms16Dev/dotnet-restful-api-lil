namespace LiL.TimeTracking.Resources;

public record Employee (int Id, String Name, DateOnly StartDate);

public record Project (int Id, String Name, DateTime StartDate, DateTime? EndDate);

public record TimeEntry (Guid Id, int EmployeeId, int ProjectId, DateOnly DateWorked, decimal HoursWorked);

public record ProjectAsignment (int EmployeeId, int ProjectId, String EmployeeName, String? ProjrctName );
