using src;
using src.Generators;
using Xunit.Abstractions;

namespace test;

public class UnitTest1
{
    private readonly ITestOutputHelper output;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
    }
    [Fact]
    public void Test1()
    {
        GenerateNameWrapper khmerName = new GenerateKhmerName();
        output.WriteLine(khmerName.Generate());
        
        Assert.NotNull(khmerName);
    }
}