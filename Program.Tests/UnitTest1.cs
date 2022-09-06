// using Program = Microsoft.VisualStudio.TestPlatform.TestHost.Program;


namespace Program.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var sut = new Program();

        //Act
        var result = sut.IsLeapYear(1700);

        //Assert
        result.Should().Be(false);
        sut.IsLeapYear(2000).Should().Be(true);
    }
    [Fact]
    public void Throw_exception_invalid_year()
    {
        var result = () => { new Program().IsLeapYear(1500);
        };
        result.Should().Throw<Exception>();
    }
    [Fact]
    public void Throw_exception_invalid_input()
    {
        var result = () => { new Program().InputToInteger("abc");
        };
        result.Should().Throw<ArgumentException>();
    }
}