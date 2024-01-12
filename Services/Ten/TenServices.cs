namespace EightToTen.Services.Ten;
public class TenServices : ITenServices
{
    public string pickRestBurg()
    {
         Random outCome = new Random();
    int number = outCome.Next(10);
    switch (number)
    {
        case 0:
            return "In N Out";
        case 1:
            return "Mc Donalds";
        case 2:
            return "5 Guys";
        case 3:
            return "Wendy's";
        case 4:
            return "The Habit";
        case 5:
            return "Burger King";
        case 6:
            return "Carls Jr";
        case 7:
            return "Jack in the Box";
        case 8:
            return "Dairy Queen";
        default:
            return "Sonic";
    }
    }

    public string pickRestChick()
    {
            Random outCome = new Random();
    int number = outCome.Next(10);
    switch (number)
    {
        case 0:
            return "Chick Fil A";
        case 1:
            return "Popeyes";
        case 2:
            return "Rasing Canes Chicken Fingers";
        case 3:
            return "The Crack Shack";
        case 4:
            return "KFC";
        case 5:
            return "Buffalo Wild Wings";
        case 6:
            return "Wing Stop";
        case 7:
            return "Fire Wings";
        case 8:
            return "Angry Chickz";
        default:
            return "el Pollo Loco";
    }
    }

    public string pickRestPizza()
    {
            Random outCome = new Random();
    int number = outCome.Next(10);
    switch (number)
    {
        case 0:
            return "Litte Ceasers";
        case 1:
            return "Jack's Pizza Cafe";
        case 2:
            return "Guidos";
        case 3:
            return "Pizza Hut";
        case 4:
            return "Mountain Mike's";
        case 5:
            return "Round Table";
        case 6:
            return "Dominos";
        case 7:
            return "Papa John's";
        case 8:
            return "Blaze Pizza";
        default:
            return "Mod Pizza";
    }
    }
}