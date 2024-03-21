using src.Extensions;
using src.Generators;
    
// Creating an instance of GenerateKhmerName class
var khmerNameGenerator = new GenerateKhmerName();

// Creating an instance of GenerateKhmerName class and using the RealNameGenerator extension method
var nonKhmerName = new GenerateKhmerName().RealNameGenerator();

Console.WriteLine(khmerNameGenerator.Generate());
Console.WriteLine(nonKhmerName);

