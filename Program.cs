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
