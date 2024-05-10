namespace DependencyProblem;

// Auto je závislé na konkrétní implementaci motoru
// Vzniká tak těžko testovatelný kód
// Příklad z fmwk. (FormPreconverter vyžaduje vstupní frm jako XDocument, co kdybychom zavedli JSON formuláře???)

public class Car
{
    public required double Weight { get; set; }
}

public class Engine
{
    public required double Displacement { get; set; }
}

public class DieselCar : Car
{
    public required DieselEngine Engine { get; set; }
}

public class PetrolCar : Car
{
    public required PetrolEngine Engine { get; set; }
}

public class DieselEngine : Engine
{

}

public class PetrolEngine : Engine
{

}