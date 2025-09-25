

//  Hi, I hope you enjoy the short text based story I created! :) 



using System;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Runtime.InteropServices;

Console.Write("\nIT IS 2 AM, YOU LIVE BY YOURSELF IN A ONE BEDROOM APARTMENT AND YOU HAVE JUST FINISHED YOUR HOMEWORK FOR TODAY.\n");

Console.Write("\nBUT THERE IS ONE LAST THING YOU NEED TO TAKE CARE OF...YOUR STOMACH.\n");

Console.WriteLine("\nIT HAS BEEN GROWLING SINCE THE BEGINNING OF YOUR STUDIES. THE RESTAURANTS ARE NOW CLOSED, BUT THE CORNER STORE IS OPEN.");

Console.WriteLine("\nYOUR LOCAL CORNER STORE JUST RELEASED A SELF-SERVE FOOD SECTION. NOODLES, FRIES, SUSHI, BURGERS, PASTRIES, AND DRINKS WILL BE AVAILABLE.\n");

Console.WriteLine("HOWEVER, YOU DON'T FEEL LIKE SPENDING YOUR MONEY ON FOOD. YOU HAVE LEFTOVER LASAGNA IN THE FRIDGE WAITING FOR YOU.");

// The player has now a choice to make.

{

    Console.Write("\nDO YOU WANT TO STAY HOME? ");

    string YesNo = Console.ReadLine();


    // If the player decides to STAY home.

    if (YesNo == "YES" || YesNo == "yes")
    {
        Console.WriteLine("\nYOU DECIDE TO STAY HOME AND ENJOY YOUR LEFTOVERS. MORE MONEY IN YOUR POCKET.");
        Console.WriteLine("\nYOU DIRECT YOURSELF TO THE FRIDGE, TAKE THE LASAGNA, AND HEAT IT UP.\n");
        Console.WriteLine("WHILE YOU'RE WAITING FOR YOUR FOOD, YOU START TO HEAR WEIRD NOISES COMING FROM YOUR BEDROOM.\n");

        // Does the player want to INVESTIGATE the noise or IGNORE it and eat their food?

        Console.Write("DO YOU WANT TO GO TO YOUR ROOM? ");

    }

    string NoYes = Console.ReadLine();

    // If the player decides to GO to their room. (Symptom of sleep deprivation: Visual hallucinations and nosebleed)

    if (NoYes == "YES" || NoYes == "yes")
    {
        Console.WriteLine("\nYOU HEAD TO YOUR ROOM AND TURN THE LIGHTS ON. YOU LOOK AROUND YOUR ROOM AND NOTICE NOTHING ABNORMAL.\n");
        Console.WriteLine("\nAS YOU WERE ABOUT TO HEAD BACK TO THE KITCHEN, SUDDENLY A RED DROPLET OF BLOOD LANDS ON YOUR CARPET.\n");
        Console.WriteLine("YOU LOOK UP AND SEE BLOOD EMERGING FROM THE CEILING OF YOUR ROOM.\n");
        Console.WriteLine("\nYOU SUDDENLY FEEL DIZZY. YOUR HEART IS POUNDING FAST.YOU ARE STARTING TO SWEAT PROFUSELY.YOUR EYES GET WATERY. AND THEN NOTHING.\n");
        Console.WriteLine("\nTHE SOUND OF THE MICROWAVE MAKES YOU SNAP OUT OF IT AND REALIZE YOU ARE HAVING A NOSEBLEED.\n");
        Console.WriteLine("YOU LET OUT A BIG SIGH AND GET A TISSUE.\n");

        Console.WriteLine("\nIT IS GOING TO BE A LONG NIGHT... \n");
    }

    // If the player decides to IGNORE the noise and wait for their food. (Symptom of sleep deprivation: Sounds hallucinations)

    else if (NoYes == "NO" || NoYes == "no")
    {
        Console.WriteLine("\nYOU DECIDE TO WAIT FOR YOUR MEAL.YOU ARE STARING AT THE MEAL GETTING HEATED UP.\n");
        Console.WriteLine("\nYOU ARE STARING TO THE POINT THAT YOU ARE LOSING YOURSELF IN THE YELLOW LIGHT OF THE MICROWAVE.\n");
        Console.WriteLine("\nSO BRIGHT... SO PRETTY TO LOOK AT.\n");
        Console.WriteLine("\nTHE HUMMING SOUND OF THE MICROWAVE IS GETTING SLOWER BY THE MINUTE, AND A LONG BEEPING SOUND COMES THROUGH.\n");
        Console.WriteLine("\THIS MAKES YOU FINALLY SNAP OUT OF IT, REALIZING YOUR FOOD IS READY.\n");


        Console.WriteLine("\nIT IS GOING TO BE A LONG NIGHT... \n");

    }
    // If the player decides to GO to the corner store. 

    if (YesNo == "NO" || YesNo == "no")
    {
        Console.WriteLine("\nYOU ARE GETTING READY TO LEAVE TO GO TO THE CORNER STORE. TEN MINUTES LATER, YOU HAVE ARRIVED.\n");
        Console.WriteLine("\nTHE CASHIER GREETS YOU WITH A NOD, AND YOU ARE HEADING TO THE SELF-SERVE FOOD SECTION.\n");
        Console.WriteLine("\nYOUR MOUTH IS SALIVATING AS YOU ARE LOOKING THROUGH YOUR OPTIONS.YOU ARE DEBATING BETWEEN TWO ITEMS.\n");
        Console.WriteLine("\nYOU LOOK AT THE BURGER, AND IT COSTS 5.00 $ MEANWHILE, THE SUSHI WILL COST YOU 10.00 $\n");



        int number1 = 10;
        float number2 = 5;

        bool areNotTheSame = number1 != 10;
        Console.WriteLine($"IS {number2} GREATER THAN {10}? {areNotTheSame}.");

        areNotTheSame = number1 != number2;
        Console.WriteLine($"IS {number1} NOT EQUAL TO {number2}? {areNotTheSame}.");



        // The player gets to pick BURGER or SUSHI.

        Console.Write("\nWITH THAT IN MIND, DO YOU TAKE THE BURGER OR SUSHI? ");
    }

    string BurSush = Console.ReadLine();

    // If the player picks BURGER. Player GETS IRRITATED BY CASHIER. (Symptom of sleep deprivation: irritability)

    if (BurSush == "BURGER" || BurSush == "burger")
    {

        Console.WriteLine("\nYOU DECIDE TO TAKE THE BURGER, AND YOU HEAD TO THE CASHIER, WHERE HE GREETS YOU WITH A SMILE. HE SCANS YOUR BURGER.\n");
        Console.WriteLine("\nYOUR TOTAL IS  5.00 $ \n");
        Console.WriteLine("\nYOU PROCEED TO DIG IN YOUR POCKET TO REACH YOUR WALLET. THE CASHIER THEN INITIATES A CONVERSATION AS YOU ARE LOOKING FOR YOUR CHANGE.\n");
        Console.WriteLine("\nTHE MORE HE WOULD SPEAK, THE MORE IT IRRITATED YOU. HE KEEPS ON TALKING WHILE YOU STRUGGLE TO REACH THE LAST 25 CENTS TO COMPLETE YOUR CHANGE.\n");
        Console.WriteLine("\nFINALLY, YOU SLAM THE COINS ON THE COUNTER AND YELL AT THE CASHIER TO SHUT UP AND GIVE YOU YOUR BURGER.\n");
        Console.WriteLine("\nWITH CONFUSION WRITTEN ON HIS FACE, HE GIVES YOU YOUR BURGER, AND YOU STORM OUT OF THE STORE.\n");

        Console.WriteLine("\nIT IS GOING TO BE A LONG NIGHT...\n");






    }
    // If the player picks SUSHI. Player FORGETS WALLET. (Symptom of sleep deprivation: forgetfulness)

    else if (BurSush == "SUSHI" || BurSush == "sushi")
    {
        Console.WriteLine("\nYOU GO WITH SUSHI. YOU HEAD TO THE CASHIER, WHERE HE GREETS YOU WITH A SMILE.HE SCANS THE PACKAGE.\n");
        Console.WriteLine("\nYOUR TOTAL IS  10.00 $\n");
        Console.WriteLine("\nYOU PROCEED TO DIG IN YOUR POCKET TO REACH YOUR WALLET.\n");
        Console.WriteLine("\n...YOU FORGOT YOUR WALLET RIGHT AT THE TABLE BY YOUR DOOR.\n");
        Console.WriteLine("\nYOU USUALLY NEVER FORGET TO PICK UP YOUR WALLET. YOU CANCEL THE TRANSACTION AND DECIDE TO HEAD BACK HOME.\n");
        Console.WriteLine("\nEMPTY STOMACH.\n");

        Console.WriteLine("\nIT IS GOING TO BE A LONG NIGHT...\n");



    }


}




// Thank you for playing ! :) Reminder to SLEEP lol!   
