using Prac.src;
namespace Prac.Test;

public class GenerateTest
{

    [Fact]
    public void GeneratedIdNotSame()
    {
        var gen = new Generator();

        string Id1 = gen.Generate();
        string Id2 = gen.Generate();

        Assert.NotEqual(Id1, Id2);
    }


    [Fact]
    public void IdNotExceeding32()
    {
        var gen = new Generator();
        string id = gen.Generate();

        Assert.Equal(8, id.Length);
    }
}
