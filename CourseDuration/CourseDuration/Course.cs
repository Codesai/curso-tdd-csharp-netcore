namespace CourseDuration;

public class Course
{
    private readonly String _name;
    private int _startTime;
    private int _durationInMinutes;

    public Course(string name) {
        _name = name;
        _durationInMinutes = 0;
    }
    
    public void Start() {
        _startTime = DateTime.Now.Millisecond;
    }
    
    public void End() {
        var endTime = DateTime.Now.Millisecond;
        _durationInMinutes = (endTime - _startTime) / (1000 * 60);
    }

    public bool IsShort() {
        var tenMinutes = 10 * 60;
        return _durationInMinutes < tenMinutes;
    }
    
    public bool IsLong() {
        return !IsShort();
    }

    public String GetTitle() {
        return $"{_name} course in {GetCollege()} college";
    }

    private string GetCollege() {
        return Environment.GetEnvironmentVariable("COLLEGE") ?? "not found";
    }
}