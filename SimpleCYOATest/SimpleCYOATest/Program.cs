///all of the following
///code is under license
///License: Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
///Any distribution of this code without explicit permission from the owner violates the owners rights via the aformentioned license
///and is therefore illegal and will be taken seriously and the ofender will be held accountable and legal action will be pursued.
///More information about this license can be found at the following webpage: 

using System;
using System.Threading;


namespace SimpleCYOATest
{
    class Program
    {
        static void intro()
        {
            #region setup and welcome
            Console.Title = "Cooper's Internet Adventure";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to Cooper's Adventure");
            Console.WriteLine();
            Sleep(1500);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            #endregion
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You wake up in the tunnel of memes, you don't remember how you got there.");
            Console.ReadKey();
            Console.WriteLine("Wait...");
            Console.ReadKey();
            Console.WriteLine("You start to remember something..., someone throwing you into the Reddit portal before you were ready...,");
            Console.WriteLine(" then an error message..., something like 'connection to the server lost'...,");
            Console.ReadKey();
            Console.WriteLine("Then...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DARKNESS...");
            Sleep(2000);
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cooper's Internet Adventure");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
        }
        static void Sleep(int mSecs)
        {
            Thread.Sleep(mSecs);
        }
        static void DeathMsg()
        {
            Console.Title = "YOU DIED";
            Console.WriteLine("YOU DIED");
            Console.WriteLine("Press any key to restart");
            Console.ReadKey();
        }
        static void Credits(string Title, string Name, int mSecs)
        {
            //for use inside of CreditShell()
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(Title + ":");
            Console.Write(Name);
            Sleep(mSecs);
        }
        static void CreditsShell(int time)
        {
            Credits("Programmer", "Cooper Makhijani", time);
            Credits("Story", "Cooper Makhijani", time);
            Credits("Project Manager", "Cooper Makhijani", time);
            Credits("Early Beta Playtesters", "Evan R.", time);
            Credits("Early Beta Playtesters", "Brandon", time);
            Credits("Publisher", "ResemblanceGames.com", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "Resemblance Games Team:", time);
            Credits("Founder", "Cooper Makhijani", time);
            Credits("Founder", "Krystof Stanek", time);
            Credits("Writer", "Soloman F.", time);
            Credits("Programmer", "Cooper Makhijani", time);
            Credits("Dedicated to", "Everyone in the Luke_lafr Discord", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "THANKS FOR PLAYING!", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Credits("", "", time);
            Console.WriteLine("Creative Commons License This work is licensed under ");
            Console.WriteLine("a Creative Commons Attribution - NonCommercial - ");
            Console.WriteLine("NoDerivatives 4.0 International License.");
            Console.WriteLine("Contact Cooper Makhijani of Resemblance Games");
            Console.WriteLine("if you would like to use this work commercially");
            Console.WriteLine("at the contact form on ResemblanceGames.com");

        }
        static void Main(string[] args)
        {
            ///used to take usrinpt
            ///ConsoleKeyInfo keyInfo = Console.ReadKey();
            intro();
        DeathRestart:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("You suddenly awake, that flashback knocked you out...");
            Sleep(200);
            Console.Write("plink...");
            Sleep(500);
            Console.Write("plink...");
            Sleep(500);
            Console.Write("plink...");
            Sleep(500);
            Console.Write("plink...");
            Sleep(500);
            Console.WriteLine("You hear water...");
            Console.WriteLine("plink...");
            Sleep(500);
            Console.Write("plink...");
            Sleep(500);
            Console.Write("plink...");
            Sleep(500);
            Console.WriteLine("plink...");
            Sleep(500);
            Console.WriteLine("You hear something coming... do you run or stay put?");
            Console.WriteLine("Press 1 to run, or press 2 to stay put");
            ConsoleKeyInfo keyInfo0 = Console.ReadKey();

            if (keyInfo0.KeyChar == '1')
            {
                Console.Clear();
                Console.WriteLine("You start running. You hear whatever it is getting closer and closer. You run faster. You slip and land on something...");
                Console.WriteLine("You see something emiting a small glow, you pick it up. It's a downvote gun.");
                Console.WriteLine("You stand up, gun in hand, and wait");
                Console.WriteLine("You see the thing run around a corner, straight at you, it's a dank meme.");
                Console.WriteLine("You fire the gun,");
                Sleep(500);
                Console.WriteLine("A downvote arrow flies at the dank meme faster than an insult on a gigabit connection");
                Console.WriteLine("It's dead...");
                Sleep(1000);
                Console.WriteLine("You hear cheering... it's coming from behind you, you turn and see...");
                Sleep(500);
                Console.Write(" nothing, wait, upon closer look you see a tiny town on the ground.");
                Console.WriteLine("There are tiny people too, you crouch down and look at them, one says something,");
                Console.WriteLine("'Here! Take this!'");
                Console.WriteLine("Something lands in your hand, it starts to grow.");
                Console.WriteLine("It grows for a bit then stops, you look closer, it says WinRoar on it,");
                Console.WriteLine("One of the people shout 'Double tab it!'");
                Console.WriteLine("You double tap it with you finger, a window pops into the air, it says 'Compress Yourself'");
                Console.WriteLine("Someone shouts 'do it!'");
                Console.WriteLine("Do you compress yourself(1) or keep walking through the tunnels(2)?");
                //get usr input
                ConsoleKeyInfo keyInfo1 = Console.ReadKey();
                //process usr input
                if (keyInfo1.KeyChar == '1')
                {
                    Console.Clear();
                    #region 2a
                    Console.WriteLine("You click Compress, a box pops up saying that the WinRoar trial has expired,");
                    Console.WriteLine("You know that WinRoar trials are really never over and it will still work, you press the [x] on");
                    Console.WriteLine("the box.");
                    Console.WriteLine("You hear a roaring in your ears, you feel like you're being crushed from all sides,");
                    Console.ReadKey();
                    Console.WriteLine("There's a loud pop and then it's over");
                    #endregion
                    Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Cooper's Internet Adventure");
                    Console.Title = "Cooper's Internet Adventure | ResemblanceGames.com";
                    Console.WriteLine("END OF: Chapter One");
                    Console.WriteLine("Subscribe to our newsletter to be notified of Chapter Two news!");
                    Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                    CreditsShell(750);
                    Sleep(1000);
                    Console.ReadKey();
                }

                else
                {
                    #region 2b
                    Console.Clear();
                    Console.WriteLine("You pass and keep walking, you don't notice the Windows 10 Force Upgrade Countdown until it's too late,");
                    Console.WriteLine("You go through a long restart and then boot up again,");
                    Console.WriteLine("Then you crash, you're bricked");
                    Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You died");
                    Console.WriteLine("Press any key to restart");
                    Console.ReadKey();
                    goto DeathRestart;
                    #endregion
                }

            }
            else
            {
                #region death0
                Console.Clear();
                Console.WriteLine("You stay put, seconds later you see a huge dank meme charge around the corner, you realise your mistake and start running, but it's too late.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU DIED");
                Console.Title = "YOU DIED";
                Console.WriteLine();
                Console.WriteLine("ResemblanceGames.com");
                Console.WriteLine("Press any key to restart");
                Console.ReadKey();
                goto DeathRestart;
                #endregion
            }
            Console.ReadKey();
        }
    }
        }
