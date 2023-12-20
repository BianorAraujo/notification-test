using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Notification.Test;

public class UnitTest
{
    [Theory(DisplayName = "Message Notification")]
    [InlineData("And now here is my secret", 15, "And now ...")]
    [InlineData("There is an animal with four legs", 15, "There is an ...")]
    [InlineData("super dog", 4, "...")]
    [InlineData("how are you", 20, "how are you")]
    [InlineData(" And now here is my secret", 15, "And now ...")]
    public void Notify_Return_Message_With_Success(string message, int K, string expected)
    {
        //Arrange
        Notify notify = new Notify();

        //Act
        string messageResult = notify.Solution(message, K);

        //Assert
        Assert.Equal(expected, messageResult);
    }
}
