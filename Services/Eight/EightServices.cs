namespace EightToTen.Services.Eight;
public class EightServices : IEightServices
{
    public string EightBall()
    {
                Random outCome = new Random();
        int number = outCome.Next(8);
        switch (number)
        {
            case 0:
                return "Outlook good";
            case 1:
                return "It is decidedly so";
            case 2:
                return "Concentrate and ask again";
            case 3:
                return "Yes!";
            case 4:
                return "My reply is no";
            case 5:
                return "Reply hazy, try again";
            case 6:
                return "Signs point to yes";
            default:
                return "Yes defintely";
        }
        // return ("");
    }
}