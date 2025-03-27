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
