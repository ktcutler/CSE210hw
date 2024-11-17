// Journal Program - Kole Cutler

// I used a mix of W3 schools, classroom notes, and ChatGPT 
// to help me with this assignment. I will describe everything
// in detail to show mastery of this project

using System;

// this is the main program where all of the classes and objects are put together for the user to interact with
class Program
{
    static void Main(string[] args)
    {
        // establish the objects that will be used in the program
        Journal myJournal = new Journal();
        Prompts myPrompts = new Prompts();
        Menu menu = new Menu(myJournal, myPrompts);

        // establish a loop that keeps running the menu until it is exited by the user
        bool continueRunningMenu = true;

        while (continueRunningMenu)
        {
            // Called the Menu class to display on the main
            menu.DisplayMenu();

            // this converts the user's input into an integer so that it can be run according to the structure of the Menu
            int choice = menu.ProcessMenu();

            // Handle user choice, I got lost and had ChatGPT give me ideas for this one. It used a switch statement instead of an else if structure
            // which I like better so I kept it. Basically it does the same thing as an else if loop but creates cases for every single option. 
            // I like this better because it looks cleaner and the logic of having cases for every single option makes more sense in my head. 
            switch (choice)
            {
                case 1:
                    menu.HandleWrite();
                    break;
                case 2:
                    menu.HandleDisplay();
                    break;
                case 3:
                    menu.HandleLoad();
                    break;
                case 4:
                    menu.HandleSave();  // Save option
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    continueRunningMenu = false;
                    break;
            }
        }
    }
}
