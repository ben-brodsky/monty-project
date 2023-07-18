var randomCar = new Random();
var randomDoor = new Random();

string finalChoice = null;
int carsPicked = 0;
int goatsPicked = 0;

Console.WriteLine("How many times should the game be played?");
int loopNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Should the player switch their choice? (y/n)");
string switchChoice = Console.ReadLine();

for (int i = 0; i <= loopNum - 1; i++)
{
    DoorGame();
}

void DoorGame()
{
    string[] doors = new string[] {"Goat", "Goat", "Goat"}; 
    string[] doorsSwitch = new string[] {"Goat", "Car"};

    //Choose one door to hold car
    doors[randomCar.Next(3)] = "Car";
    // Console.WriteLine(doors[0] + doors[1] + doors[2]);
    //Player chooses door 
    int userChoice = randomDoor.Next(3);

    //Reveal 1 goat door, user decides to switch or not 
    if (doors[userChoice] == "Car")
    {
        doorsSwitch[0] = "Car";
        doorsSwitch[1] = "Goat";
    }

    if (switchChoice == "n")
    {
        finalChoice = doorsSwitch[0];
    }
    else if (switchChoice == "y")
    {
        finalChoice = doorsSwitch[1];
    }

    if (finalChoice == "Goat")
    {
        goatsPicked++;
    }
    else if (finalChoice == "Car")
    {
        carsPicked++;
    }
}

Console.WriteLine("Total number of cars picked:" + " " + carsPicked);
Console.WriteLine("Total number of goats picked:" + " " + goatsPicked);




