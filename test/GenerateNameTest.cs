using src;
using src.Extensions;
using src.Generators;
using Xunit.Abstractions;

namespace test;

public class GenerateNameTest
{
    private readonly ITestOutputHelper output;

    public GenerateNameTest(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void KhmerNameTest()
    {
        GenerateNameWrapper khmerName = new GenerateKhmerName();
        output.WriteLine(khmerName.Generate());

        Assert.NotNull(khmerName);
    }

    [Fact]
    public void RealNameGenerateTest()
    {
        var realNameGenerator = new GenerateKhmerName().RealNameGenerator();
        output.WriteLine(realNameGenerator);

        Assert.NotNull(realNameGenerator);
    }
}