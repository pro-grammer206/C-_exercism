public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        string description;
        switch (shirtNum)
        {
            case 1:
                description = "goalie";
                break;
            case 2:
                description = "left back";
                break;
            case 3:
            case 4:
                description = "center back";
                break;
            case 5:
                description = "right back";
                break;
            case 6:
            case 7:
            case 8:
                description = "midfielder";
                break;
            case 9:
                description = "left wing";
                break;
            case 10:
                description = "striker";
                break;
            case 11:
                description = "right wing";
                break;
            default:
                throw new ArgumentOutOfRangeException();

        }
        return description;
    }
    public static string AnalyzeOffField(object Report)
    {
        string message;
        switch (Report)
        {
            case int supporters:
                message = $"There are {supporters} supporters at the match.";
                break;
            case string msg:
                message = msg;
                break;
            case Foul foul:
                message = foul.GetDescription();
                break;
            case Injury injury:
                message = injury.GetDescription();
                break;
            case Incident inc:
                message = inc.GetDescription();
                break;
            case Manager manager when manager.Club == null:
                message = $"{manager.Name}";
                break;
            case Manager manager:
                message = $"{manager.Name} ({manager.Club})";
                break;
            default:
                throw new ArgumentException();
        }
        return message;
    }
}
public class Manager
{
    public string Name { get; }

    public string? Club { get; }

    public Manager(string name, string? club)
    {
        this.Name = name;
        this.Club = club;
    }
}

public class Incident
{
    public virtual string GetDescription() => "An incident happened.";
}

public class Foul : Incident
{
    public override string GetDescription() => "The referee deemed a foul.";
}

public class Injury : Incident
{
    private readonly int player;

    public Injury(int player)
    {
        this.player = player;
    }

    public override string GetDescription() => $"Player {player} is injured.";
}