using System;


namespace programFlyt_customizedGreeting;

class Program
{
    static void Main(string[] args)
    {
        string timeOfDay = DateTime.Now.ToString("HH");
        string exactTime = DateTime.Now.ToString("HH:MM");
        Console.WriteLine(timeOfDay);
        int convertedTime = Convert.ToInt32(timeOfDay);
        Console.WriteLine("TELL ME YOUR NAME, YOU PEASANT:\n");
        
        string? usernameA = Console.ReadLine();
        string? usernameD = usernameA.ToUpper();

        if (convertedTime >= 5 && convertedTime <= 9) //IF TIME IS LESS THAN 9 AND BIGGER THAN 5.
        {
            Console.WriteLine($"GOOD MORNING SUNSHINE, I HOPE YOU HAD A GOOD NIGHTS SLEEP {usernameD}. ITS CURRENTLY: {exactTime} IN THE MORNING.");
        }
        else if (convertedTime >= 9 && convertedTime <= 12 ) //IF TIME IS LESS THAN 12 AND BIGGER THAN 9
        {
            Console.WriteLine($"GOOD FORENOON MOTHERLOVIN' {usernameD}. ALMOST LUNCHTIME, HOPE YOUR BROUGHT A LUNCHABLES. BY THE WAY ITS {exactTime} O'CLOCK");
        }
        else if (convertedTime >= 12 && convertedTime <= 17 ) //IF TIME IS LESS THAN 17 AND BIGGER THAN 12
        {
            Console.WriteLine($"YO {usernameD}, OR GOOD DAY, I MEAN. IT IS {exactTime} O'CLOCK.");
        }
        else if (convertedTime >= 17 && convertedTime <= 21) //IF TIME IS LESS THAN 21 AND BIGGER THAN 17
        {
            Console.WriteLine($"GOOD EVENIN IN DA HOOD. AT {exactTime} IT MIGHT BE UNSAFE IN THE HOOD. MIGHT CONSIDER STAYING IN TO STAY SAFE NOW, BUD {usernameD}");
        }
        else
        {
            Console.WriteLine($"WHY THE FUCK YOU AWAKE, DAWG. FREAK'N'{usernameD}y"); //IF TIME IS DIFFERENT THAN SO!
        }
    }

}

/*
PSEUDOKODE.

START PROGRAM
IMPORT DATETIME

VAR TIMEINDAY
RETRIEVE THE TIMEINDAY VARIABLE IN PROPER FORMAT (TIME: BETWEEN 00 AND 23) AND CONVERT IT TO THE RIGHT DATATYPE (INT)

ASK THE USER FOR NAME, SO WE CAN MAKE A PERSONAL GREETING, MAKING THE USER FEEL MORE WELCOME USING OUR HIGH TECH SOFTWARE (AND THEN WE FORGET ABOUT IT IN THE FUTURE).

CREATE IF STATEMENTS
IF TIME IS LESS THAN 9 AND BIGGER THAN 5:
    THEN GOOD MORNING
IF TIME IS LESS THAN 12 AND BIGGER THAN 9:
    THEN GOOD FORENOON
IF TIME IS LESS THAN 17 AND BIGGER THAN 12:
    THEN GOOD AFTERNOON
IF TIME IS LESS THAN 21 AND BIGGER THAN 17:
    THEN GOOD EVENING
ELSE
    GOOD NIGHT
GREET THE USER "GOOD [MORNING/FORENOON/AFTERNOON/EVENING/NIGHT] IT IS NOW [TIME] O CLOCK.


END PROGRAM


Arvid viste en kjempebra løsning med Dictionary og keys for å gå gjennom tid og greetings. Skal se på det ila. helga! Du har nok ikke retta oppgavene by then anyway hehe!



DISCLAIMER: Hiphop pumped personality this week! Who knows what next assignment will bring?!

*/