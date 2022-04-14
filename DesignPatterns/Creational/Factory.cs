
namespace DesignPatterns.Creational;

public interface IInterviewer
{
    void AskQuestions();
}

public class Developer : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("Asking about design patterns!");
    }
}

public class CommunityExecutive : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("Asking about community building");
    }
}

public abstract class HiringManager
{
    // Factory method
    public abstract IInterviewer MakeInterviewer();

    public void TakeInterview()
    {
        var interviewer = MakeInterviewer();
        interviewer.AskQuestions();
    }
}

public class DevelopmentManager : HiringManager
{
    public override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}

public class MarketingManager : HiringManager
{
    public override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}

