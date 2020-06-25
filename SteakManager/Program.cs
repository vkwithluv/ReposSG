namespace SteakManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Controllers.SteakController.Run();

        }
    }
}



/***FLOW CHART
 * START
 * ->Prompt Menu: 1.Create, 2.Display, 3.Search, 4.Edit, 5.Remove, ESC to Quit
 * User input menu choice by assigned number:
    User input:1
     -> print Creata a new Steak, to continue press 1, to return to main menu press 2
        -> IF user imput confirmation 1: Call method (controller) assigned to menu number
            1. Private CreateSteak(): void
        -> ELSE user imput confirmation 2:Prompt Menu: 1.Create, 2.Display, 3.Search, 4.Edit, 5.Remove, ESC to Quit
     -> print List of All Steaks in Current Inventory,to continue press 1, to return to main menu press 2
        -> IF user imput confirmation 1: Call method (controller) assigned to menu number
            2. Private DisplaySteak(): void
        -> ELSE user imput confirmation 2:Prompt Menu: 1.Create, 2.Display, 3.Search, 4.Edit, 5.Remove, ESC to Quit
     -> print Search for a Steak by Id Number, to continue press 1, to return to main menu press 2
        -> IF user imput confirmation 1: Call method (controller) assigned to menu number
            3. Private SearchSteak(): void
        -> ELSE user imput confirmation 2:Prompt Menu: 1.Create, 2.Display, 3.Search, 4.Edit, 5.Remove, ESC to Quit
     -> print Edit a Steak in the Current Inventory, to continue press 1, to return to main menu press 2
        -> IF user imput confirmation 1: Call method (controller) assigned to menu number
            4. Private EditSteak() : void
        -> ELSE user imput confirmation 2:Prompt Menu: 1.Create, 2.Display, 3.Search, 4.Edit, 5.Remove, ESC to Quit
     -> print Remove a Steak from the Current Inventory, to continue press 1, to return to main menu press 2
        -> IF user imput confirmation 1: Call method (controller) assigned to menu number
            5. Private RemoveSteak() : void
        -> ELSE user imput confirmation 2:Prompt Menu: 1.Create, 2.Display, 3.Search, 4.Edit, 5.Remove, ESC to Quit
     -> readkey:ESC, exit program
 * 
