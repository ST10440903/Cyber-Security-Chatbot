using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Cyber_Security_Chatbot
{
   
    class CyberSecurityChatbot
    {
         static void Main() //methods for the chat bot are called out here 
         {
             GreetingMessage();
             DisplayAsciiArt();
             StartChat();
         }

        static void GreetingMessage() //Audio greeting message for chatbot
        {
            try
            {
                SoundPlayer player = new SoundPlayer("welcome.wav");  //Audio file is linked here
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error can't find the message : " + ex.Message);
            }
        }


        public static void DisplayAsciiArt()   //ASCII art display
          {
               Console.Clear(); // Clears the screen for a clean display
               Console.WriteLine("========================================");
               Console.WriteLine("  WELCOME TO THE PHANTOM TECH BOT  ");
               Console.WriteLine("========================================");
               Console.WriteLine(@"  
         ooooooooo.   ooooo   ooooo       .o.       ooooo      ooo ooooooooooooo   .oooooo.   ooo        ooooo 
         `888   `Y88. `888'   `888'      .888.      `888b.     `8' 8'   888   `8  d8P'  `Y8b  `88.       .888' 
          888   .d88'  888     888      .8""888.      8 `88b.    8       888      888      888  888b     d'888  
          888ooo88P'   888ooooo888     .8' `888.     8   `88b.  8       888      888      888  8 Y88. .P  888  
          888          888     888    .88ooo8888.    8     `88b.8       888      888      888  8  `888'   888  
          888          888     888   .8'     `888.   8       `888       888      `88b    d88'  8    Y     888  
         o888o        o888o   o888o o88o     o8888o o8o        `8      o888o      `Y8bood8P'  o8o        o888o 
   
          [Phantom Tech - Digital Security Experts] ");
       
               Console.WriteLine("========================================");
          }
        
        static void StartChat()  //Chat bot response and stored information
        {
            Console.Write("Hello! What's your name? ");
            string name = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(name))
            {
                name = "User";
            }
            Console.WriteLine($"Welcome, {name}! I am your CyberSecurity Assistant.");
            Console.WriteLine("Ask me about cybersecurity topics like password safety, phishing, safe browsing and malware protection ");

            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("[Chatbot] Sorry, I didn't catch that. Could you rephrase?");
                    continue;
                }

                switch (input)
                {
                    case "password safety":
                        Console.WriteLine("[Chatbot] Use a mix of letters, numbers, and symbols. Never reuse old passwords!");
                        break;
                    case "phishing":
                        Console.WriteLine("[Chatbot] Avoid clicking on suspicious links and always verify email senders.");
                        break;
                    case "safe browsing":
                        Console.WriteLine("[Chatbot] Keep your browser updated and use reputable security extensions.");
                        break;
                    case "two-factor authentication":
                        Console.WriteLine("[Chatbot] Always enable 2FA for extra security. Use an authenticator app instead of SMS.");
                        break;
                    case "malware protection":
                        Console.WriteLine("[Chatbot] Install reliable antivirus software and avoid downloading files from unknown sources.");
                        break;
                    case "public WiFi risks":
                        Console.WriteLine("[Chatbot] Avoid accessing sensitive accounts on public WiFi. Use a VPN for added security.");
                        break;
                    case "social engineering":
                        Console.WriteLine("[Chatbot] Be cautious of unsolicited messages asking for personal information. Always verify identities.");
                        break;
                    case "ransomware":
                        Console.WriteLine("[Chatbot] Regularly back up important data and never pay ransom demands. Keep your system updated.");
                        break;
                    case "software updates":
                        Console.WriteLine("[Chatbot] Keep your OS and applications updated to patch security vulnerabilities.");
                        break;
                    case "email security":
                        Console.WriteLine("[Chatbot] Never open attachments from unknown senders. Check email addresses for spoofing.");
                        break;
                    case "secure websites":
                        Console.WriteLine("[Chatbot] Only enter personal information on sites that use HTTPS and have valid security certificates.");
                        break;
                    case "data privacy":
                        Console.WriteLine("[Chatbot] Limit the personal information you share online. Adjust privacy settings on social media.");
                        break;
                    case "exit":
                        Console.WriteLine("[Chatbot] Goodbye! Stay safe online.");
                        return;
                    default:
                        Console.WriteLine("[Chatbot] I'm not sure about that. Try asking about 'password safety', 'phishing', or 'safe browsing'.");
                        break;
                }
            }
        }
    }
}
