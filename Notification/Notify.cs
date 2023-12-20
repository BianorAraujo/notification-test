namespace Notification;

public class Notify
{
    public string Solution(string message, int K)
    {
        if (message.Length == 0)
        {
            return "...";
        }

        string[] words = message.Split(' ');
        string messageResult = string.Empty; 

        for (int i = 0; i < words.Length; i++)
        {
            if (message.Length < K)
                return message;

            if (message.Length <= 0)
                return "...";

            if (i > 0)
                messageResult += " ";

            if (messageResult.Length <= K)
            {
                if ((messageResult + words[i]).Length < K - 3)
                {
                    messageResult += words[i];
                }
                else
                {
                    return messageResult += "...";
                }
            }
            else
            {
                return messageResult += "...";
            }
        }

        return message;
    }

}

