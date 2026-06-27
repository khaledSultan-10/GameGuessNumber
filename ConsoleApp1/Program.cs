Random rand = new Random ();
int secretNumber = rand.Next (1,101);

System.Console.WriteLine("Wolecome to guess Game numbers you have to choose between 1-100 if you guess it right YOU WIN");
System.Console.WriteLine("the roles of the game\n1-You have 5 trys only if is it finsh you lose");
System.Console.WriteLine("2-If the number you choose bigger there a message to tell you and the oppiste as well");
System.Console.WriteLine("3-If you write anything its will count as try even if it was a chirchters");
System.Console.WriteLine("4-It intger numpers only there is no floot");
System.Console.WriteLine("that set GOOD LUCK!!");
int i = 5;
int userchoose;
 while (i > 0)
{
    System.Console.Write("choose your number :");
    if (!int.TryParse (Console.ReadLine () , out userchoose))
{
    
    i--;
    if (i == 0)
   {
    System.Console.WriteLine($"you loose the number was {secretNumber}");
    break;
    }

    System.Console.Write("choose intger numbers only , ");
    youhaveleft();
    continue;
}


  if (userchoose == secretNumber)
    {
        System.Console.WriteLine("CONGRATULATIONS!! YOU GUSSET RIGHT!!");
        break;
    }

     i--;
    if (i == 0)
   {
    System.Console.WriteLine($"you loose the number was {secretNumber}");
    break;
    }

  else if (userchoose > secretNumber)
    {
        System.Console.WriteLine("your number is bigger");
        
    }

  else if (userchoose < secretNumber)
    {
        System.Console.WriteLine("your number is smaller");
        
    }

    youhaveleft();

}


void youhaveleft()
{
System.Console.WriteLine($"You have {i} try left");
}