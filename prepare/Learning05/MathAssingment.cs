namespace Learning05;

public class MathAssignment : Assignment
{
    private readonly string _section;
    private readonly string _problemSet;

    public MathAssignment(string studentName, string topic, string section, string problemSet)
        : base(studentName, topic)
    {
        _section = section;
        _problemSet = problemSet;
    }

    public string GetHomeworkList()
    {
        return $"{_section} Problems {_problemSet}";
    }
}