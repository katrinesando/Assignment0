// using Program = Microsoft.VisualStudio.TestPlatform.TestHost.Program;

namespace Program.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var sut = new Leap.LeapYear();
        
        //Act
        var result = sut.isLeapYear(42);
        
        //Assert
        result.Should().Be(false);
        sut.isLeapYear(24).Should().Be(true);
    }
}