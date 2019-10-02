using System;

namespace is_authorized
{
    class Program
    {
        static void Main(string[] args)
        {
            
        System.Console.WriteLine("Du behöver skriv in tre(3) lösenord i korrekt ordning.");
        System.Console.WriteLine("Du har fem(5) försök på dig!");
        string[] passwords = new string[3];

        //Counter, håller koll på antal försök. Användaren har 5 försök x 3 lösenord. dvs counter==15.
        //Whileloop som körs fram till att användaren har skrivit in 15st lösenord eller att rätt lösenords skrivs in.
        int counter = 0;

        while(counter < 15)
        {
        for(int i = 0; i < passwords.Length; i++)
          {
            System.Console.Write("Skriv in lösenord: ");
            string inputPassword = Console.ReadLine();
            passwords[i] = inputPassword;
            counter++;
          }
        
        //Sparar metod som bool för att kunna få tillbaka true or false. Skickar in array med sparade element/lösenord.
        bool loggedIn = isAuthorised(passwords);


        //Om man skriver in rätt lösenord och i korrekt ordning = true, grattis!
        //Om man matar in 3st lösenord fel, gå tillbaka till whileloop och skriv in nya lösenord.
        //antalförsök blir counter / 3

        if(loggedIn == true)
        {
            Console.Clear();
            System.Console.WriteLine("Grattis! Du har hackat hela internet!!");
            break;
            
        } 
        else
        {
            Console.Clear();
            System.Console.WriteLine("***Fel, du måste skriva in alla tre lösenord rätt och i korrekt ordning!***");
            System.Console.WriteLine("***Försök igen...***");
            //Räknar antal försök.
            System.Console.WriteLine("Antal försök: {0} av 5", counter/3);

            if(counter == 15)
            {
                System.Console.WriteLine("Sorry, det gick inte denna gång...");
            }
        } 

        }
        }

        //Metod tar int string array som innehåller lösenord som användaren har skrivit in.
        //Om användaren skriver in fel lösenord returernas false och programmet går tillbaka till whileloop i Main()
       static bool isAuthorised(string[] passwords)

       {
        if(passwords[0] == "hej97" && passwords[1] == "tjo98" && passwords[2] == "halloj99") 
         {
           return true;
         }  
        else
         {
           return false;
         } 
       }
    }
}
