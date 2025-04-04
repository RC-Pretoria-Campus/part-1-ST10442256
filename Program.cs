using System;
using System.Speech.Synthesis;

class CybersecurityAwarenessBot
{
    static void Main()
    {
        PlayVoiceGreeting();
        GreetUser();
    }

    static void PlayVoiceGreeting()
    {
        using (SpeechSynthesizer synth = new SpeechSynthesizer())
        {
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.Rate = 0;
            string welcomeMessage = "Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.";
            synth.Speak(welcomeMessage);
            Console.WriteLine(welcomeMessage);
        }
    }

    static void GreetUser()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nWelcome, {userName}! I'm here to help you stay safe online.\n");
        Console.WriteLine("You can ask me about topics like phishing, password safety, or browsing securely.");
    }
}
using System;
using System.Speech.Synthesis;

class CybersecurityAwarenessBot
{
    static void Main()
    {
        PlayVoiceGreeting();
        DisplayAsciiArt();
        GreetUser();
    }

    static void PlayVoiceGreeting()
    {
        using (SpeechSynthesizer synth = new SpeechSynthesizer())
        {
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.Rate = 0;
            string welcomeMessage = "Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.";
            synth.Speak(welcomeMessage);
            Console.WriteLine(welcomeMessage);
        }
    }

    static void DisplayAsciiArt()
    {
        Console.WriteLine("#############################################");
        Console.WriteLine("#        Cybersecurity Awareness Bot         #");
        Console.WriteLine("#############################################");
        Console.WriteLine("#   _____           _                       #");
        Console.WriteLine("#  / ___|         ()                      #");
        Console.WriteLine("# | |     ___ _ __  _ _ __   __ _ _ __ _   _ #");
        Console.WriteLine("# | |    / _ \\ '_ \\| | '_ \\ / ` | '_| | | |#");
        Console.WriteLine("# | ||  __/ | | | | | | | (| | |  | |_| |#");
        Console.WriteLine("#  \\\\|| |||| ||\\,||   \\_, |#");
        Console.WriteLine("#                                      __/ |#");
        Console.WriteLine("#                                     |_/ #");
        Console.WriteLine("#############################################\n");
    }

    static void GreetUser()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nWelcome, {userName}! I'm here to help you stay safe online.\n");
        Console.WriteLine("You can ask me about topics like phishing, password safety, or browsing securely.");
    }
}
using System;
using System.Speech.Synthesis;

class CybersecurityAwarenessBot
{
    static void Main()
    {
        PlayVoiceGreeting();
        DisplayAsciiArt();
        GreetUser();
        RespondToQuestions();

        Console.WriteLine("\nThank you for chatting with the Cybersecurity Awareness Bot. Stay safe online!");
    }

    static void PlayVoiceGreeting()
    {
        using (SpeechSynthesizer synth = new SpeechSynthesizer())
        {
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            synth.Rate = 0;
            string welcomeMessage = "Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.";
            synth.Speak(welcomeMessage);
            Console.WriteLine(welcomeMessage);
        }
    }

    static void DisplayAsciiArt()
    {
        Console.WriteLine("#############################################");
        Console.WriteLine("#        Cybersecurity Awareness Bot         #");
        Console.WriteLine("#############################################");
        Console.WriteLine("#   _____           _                       #");
        Console.WriteLine("#  / ___|         ()                      #");
        Console.WriteLine("# | |     ___ _ __  _ _ __   __ _ _ __ _   _ #");
        Console.WriteLine("# | |    / _ \\ '_ \\| | '_ \\ / ` | '_| | | |#");
        Console.WriteLine("# | ||  __/ | | | | | | | (| | |  | |_| |#");
        Console.WriteLine("#  \\\\|| |||| ||\\,||   \\_, |#");
        Console.WriteLine("#                                      __/ |#");
        Console.WriteLine("#                                     |_/ #");
        Console.WriteLine("#############################################\n");
    }

    static void GreetUser()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nWelcome, {userName}! I'm here to help you stay safe online.\n");
        Console.WriteLine("You can ask me about topics like phishing, password safety, or browsing securely.");
    }

    static void RespondToQuestions()
    {
        string input = "";

        while (input != "exit")
        {
            Console.WriteLine("\nAsk me something about cybersecurity (type 'exit' to quit):");
            input = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("You didn't enter anything. Please try again.");
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm just a bot, but I'm always ready to help you stay safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to educate you on cybersecurity and help you avoid online threats.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Always use strong, unique passwords for different accounts. Avoid reusing passwords.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Phishing attacks often come through email or messages. Be cautious of links and attachments from unknown sources.");
            }
            else if (input.Contains("browsing"))
            {
                Console.WriteLine("Use secure websites (look for https) and avoid clicking on suspicious pop-ups or ads.");
            }
            else if (input == "exit")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("I didn't quite understand that. Could you rephrase?");
            }
        }
    }
}
