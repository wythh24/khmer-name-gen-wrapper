using NameGenerator;
using NameGenerator.Generators;

namespace src.Extensions;

public static class GenerateNameWrapperExtension
{
    private static GeneratorBase _GeneratorBase { get; set; }

    public static string RealNameGenerator(this GenerateNameWrapper generator)
    {
        _GeneratorBase = new RealNameGenerator();
        return _GeneratorBase.Generate();
    }
}