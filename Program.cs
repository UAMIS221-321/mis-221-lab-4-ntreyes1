// start main
int userChoice = GetUserChoice();
// pretest loop
while(userChoice!=3) { // condition check
RouteEm(userChoice); 
userChoice = GetUserChoice();
}
// post-test loop
//do {
//    RouteEm(userChoice);
//    userChoice = GetUserChoice();
//} while (userChoice!=3);

// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");

}

static bool IsValidChoice(string userInput) {
    if(userInput =="1" || userInput =="2" || userInput=="3") {
        return true;
    }
    return false;
}

static string GetFull() {
    int numRows = new Random().Next(3, 10);
    string triangle = "";
    for (int i = 1; i <= numRows; i++) {
        for (int j = 1; j<= i; j++) {
            triangle += "o";
        }
        triangle += "\n";
    }
    return triangle;
    PauseAction();
}

static string GetPartial() {
        int numRows = new Random().Next(3, 10);
        string triangle = "";
        for (int i = 1; i <= numRows; i++) {
            for (int j = 1; j <= i; j++) {
                if (new Random().Next(2) == 0) {
                    triangle += "o";
                } else {
                    triangle += " ";
                }
            }
            triangle += "\n";
        }
        return triangle;
        PauseAction();
    }


static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
   PauseAction();
}


static void RouteEm(int menuChoice) {
    if (menuChoice==1) {
        Console.Clear();
        Console.WriteLine(GetFull());
        PauseAction();
    }
    else if (menuChoice==2) {
        Console.Clear();
        Console.WriteLine(GetPartial());
        PauseAction();
    }
    else {
        Console.Clear();
        SayInvalid();
    }
    
}


static void PauseAction() {
    System.Console.WriteLine("Press any key to return to main menu...");
    Console.ReadKey();
}