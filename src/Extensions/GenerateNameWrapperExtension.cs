﻿using NameGenerator;
using NameGenerator.Generators;

namespace src.Extensions;

public static class GenerateNameWrapperExtension
{
    private static GeneratorBase? GeneratorBase { get; set; }

    /// <summary>
    /// Generates a non-Khmer name using the provided GenerateNameWrapper.
    /// </summary>
    /// <param name="generator">An instance of GenerateNameWrapper</param>
    /// <returns>A string representing the generated non-Khmer name</returns>
    public static string RealNameGenerator(this GenerateNameWrapper generator)
    {
        GeneratorBase = new RealNameGenerator();
        return GeneratorBase.Generate();
    }
}