using System;
using System.IO;
using Xunit;

public class ProgramTest
{
    [Fact]
    public void HelloWorldOutputTest()
    {
        var sw = new StringWriter();
        Console.SetOut(sw);
        Program.Main(new string[0]);

        var result = sw.ToString().Trim();
        Assert.Equal("Hello, World!", result);
    }
}
