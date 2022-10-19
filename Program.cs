//Marcel Rodriguez
//10-19-22
//Restaurant Picker
//This program will let the user pick from 30 different restaurants across 3 categories
//peer review - 

Console.Clear();

string end = "yes";
while(end == "yes")
{

bool isContainer = false;
bool isNumberCheck;
int validNum = 0;
string foodChoice = "";

while(isContainer == false)
{
    Console.WriteLine("What type of food do you want?\nMexican, American, or Chinese?");
    foodChoice = Console.ReadLine().ToLower();
    isNumberCheck = Int32.TryParse(foodChoice, out validNum);

    if(isNumberCheck == false)
    {
        isContainer = true;

        Random rndNum = new Random();
        long num = rndNum.Next(1,10);

        switch(foodChoice)
        {
            case "mexican":

            switch(num)
            {
                case 1:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Xochimico's");
                Console.WriteLine("---------------------------------");
                break;

                case 2:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Taco Bell");
                Console.WriteLine("---------------------------------");
                break;

                case 3:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Alberto's");
                Console.WriteLine("---------------------------------");
                break;

                case 4:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Las Palmas");
                Console.WriteLine("---------------------------------");
                break;

                case 5:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Taco truck beind Target");
                Console.WriteLine("---------------------------------");
                break;

                case 6:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Taco truck in front of Target");
                Console.WriteLine("---------------------------------");
                break;

                case 7:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Taco truck inside Target");
                Console.WriteLine("---------------------------------");
                break;

                case 8:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Nena's");
                Console.WriteLine("---------------------------------");
                break;

                case 9:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Tio Pepe's");
                Console.WriteLine("---------------------------------");
                break;

                case 10:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Flacko's Tacos");
                Console.WriteLine("---------------------------------");
                break;

                default:

                break;
            }

            break;

            case "american":

            switch(num)
            {
                case 1:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Dominos");
                Console.WriteLine("---------------------------------");
                break;

                case 2:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("McDonalds");
                Console.WriteLine("---------------------------------");
                break;

                case 3:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Burger King");
                Console.WriteLine("---------------------------------");
                break;

                case 4:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Chipotle");
                Console.WriteLine("---------------------------------");
                break;

                case 5:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Wendys");
                Console.WriteLine("---------------------------------");
                break;

                case 6:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("KFC");
                Console.WriteLine("---------------------------------");
                break;

                case 7:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Sonic");
                Console.WriteLine("---------------------------------");
                break;

                case 8:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Moo Moo's");
                Console.WriteLine("---------------------------------");
                break;

                case 9:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Carl's Jr");
                Console.WriteLine("---------------------------------");
                break;

                case 10:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Chick-fil-a");
                Console.WriteLine("---------------------------------");
                break;

                default:

                break;
            }

            break;

            case "chinese":

            switch(num)
            {
                case 1:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Panda Express");
                Console.WriteLine("---------------------------------");
                break;

                case 2:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Dave Wong's");
                Console.WriteLine("---------------------------------");
                break;

                case 3:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Yen Du Restaurant");
                Console.WriteLine("---------------------------------");
                break;

                case 4:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Freddy's Wok and Talk");
                Console.WriteLine("---------------------------------");
                break;

                case 5:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("China Express");
                Console.WriteLine("---------------------------------");
                break;

                case 6:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("The Chopstick");
                Console.WriteLine("---------------------------------");
                break;

                case 7:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Golden Bowl Restaurant");
                Console.WriteLine("---------------------------------");
                break;

                case 8:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Dim Sum");
                Console.WriteLine("---------------------------------");
                break;

                case 9:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Ramen 101");
                Console.WriteLine("---------------------------------");
                break;

                case 10:
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Sun Won Kee");
                Console.WriteLine("---------------------------------");
                break;

                default:

                break;
            }

            break;

            default:
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please Choose one of the categories above: ");
            Console.WriteLine("---------------------------------");

            isContainer = false;
            break;
        }
    }
    else
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Please enter a name and not a number XD");
        Console.WriteLine("---------------------------------");
    }
}

Console.WriteLine("Do you want to choose again? Yes/No");
end = Console.ReadLine().ToLower();

}