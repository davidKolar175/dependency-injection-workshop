namespace DependencyProblem;

// Nově motor injektujeme do auta, může se jednat klidně i o elektrický motor.
// Kód se stává lépe testovatelným
// Proč Interface? Proč ne abstraktní třída?

public class Car_Refactored
{
    private readonly IEngine _engine;

    public Car_Refactored(IEngine engine)
    {
        _engine = engine;
    }

    public void Vroom()
    {
        throw new Exception(_engine.Displacement.ToString());
    }
}

public interface IEngine
{
    public double Displacement { get; set; }
}
