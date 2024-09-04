using App;
using FlintSoft.Version;
using FluentAssertions;
namespace LibTests;

public class VersionTests
{
    [Fact]
    public void ExtensionMethod_Should_ReturnVersion()
    {
        var res = typeof(AssemblyWrapper).Assembly.GetVersion();

        res.Should().Be("9.8.7");
    }
}