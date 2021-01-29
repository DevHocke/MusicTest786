﻿using System;
using System.Media;
using System.Reflection;
using System.Threading;

namespace MusicTest786
{
    class Program
    {
        static void Main(string[] args)
        {    
            var soundLocation = Environment.CurrentDirectory + @"..\..\..\..\WavKakashiFightSongUP3.wav"; 
            SoundPlayer player = new SoundPlayer(@"..\..\..\..\KakashiFightSongUP3.wav");
            player.PlayLooping();
            EndStory();
            static void EndStory()
            {
                string[] stories = new string[]
                {
                "\t After fighting Orochimaru for hours you finally wear him down and kill him.",
                
                "\n\t As you dry Orochimaru's blood from your weapon on his Flack jacket. \n" +
                "\t You hear faint sounds deeper into the cave and you sense it is Hanare!\n " +
                "\n\t This fight is far from over, Orochimura did not do this on his own..." +
                "\n\t You both sense and hear more enemies deeper inside tha cave system. ",


                "\n\t As you walked further into the huge cave system Hanares cry for help \n" +
                "\t get's clearer. You are closing in on her! \n",
                
                "\t Suddenly you sense danger from behinde and instinctivly make a Shinobi backflip! \n" +
                "\n\t You dodge the sword that was beeing aimed at your back with full force!" +
                "\n\t You knew it! It is the filty backstabbing Akatsuku Clan! \n" +
                "\n\t Nobody else would ever try to kill a Shinobi from behinde." +
                "\n\t Three Akatsuku are attacking and they have you cornered. \n",

                "\t Beeing a true ninjutsu hero you are draw your Weapon and counter attack. \n" +
                "\t The closest attacker throws a Kunai aimed at your heart! \n" +
                "\n\t You use your chakra and redirect the knife into on of the other dirty" +
                "\n\t Akatsu scumbag's! \n",

                "\t This fight did not last longer then a few minutes. \n" + 
                "\n\t They where weak and in your way. \n" +
                "\t Now they are all very very dead...\n",

                "\t You sense Hanare is close and you walk into one of the dark side tunnels...\n" +
                "\t Your senses also tells you that Hanare is not alone! \n" +
                "\t Someone with the ability to hide his true powers is also present.\n",

                "\t Who is this, and how can he block your senses? \n" +
                "\t You know that the enemy and Hanare is just around the next corner. \n" +
                "\t As you draw your weapon and sneak around the corner you se Hanare and him, HIM...\n\n",

                "\t This is impossible... He is dead!?! \n" + 
                "\t you know you killed him and every last member of their Clan. \n" +
                "\t this cant be!?! Kakuzu's alive? \n",

                "\t Kakuzu laughs like a mad man when he sees your confusion “HA HA HA HA“ \n" +
                "\n\t “Did you not know that I teamed up with Orihime Inoue years ago? YOU FOOL!“ \n" +
                "\t “Orihime brought me back from the dead not more then 30 minutes after you left! \n" +
                "\t “She truly is special my dear Orihime...“",

                "\t “You should have killed her when you had the chance!“ \n" +
                "\n\t “Instead I will now kill someone near and dear to you! \n" +
                "\t “I want you to watch me kill Hanare before I come back and kill you to!” \n" +
                "\t “GRAB HIM!!!“\n",

                "\t You are suddenly overwhelmed by enemies pulling you down towards the ground, \n" +
                "\t where did they come from!? \n" +
                "\t Kakuzu must have used his {ability} to block your senses! \n",

                "\t Well, if this how he wants to play, fine by me! \n" +
                "\t “You shall meet your own powers you fool!“ \n\n" +
                "\t You remove your forhead protector and use your sharingan! \n" +
                "\n\t Your insight in Kakuzu's powers makes you block his senses \n" +
                "\t and he has no idea that you are approaching him. \n\n " +
                "\t Until its to late... \n",

                "\t “The rage {players.name} unleashed upon Kakuzu \n" + 
                "\t has never been seen from any Shinobi ever before.\n",

                "\n\t A true Shinobi are known to keep their cool even when angry! \n" +
                "\t The story of this fight will live on as a tale forever...“\n",

                "\t As you come back to your senses you rush to Hanare \n" + 
                "\t and untie the ropes around her hands and neck \n" +
                "\t she is still unconscious and very very weak. \n ",

                "\n\t Without a second of rest you pick Hanare up and \n" + 
                "\t carry her all the way back to The Hidden Leaf Village.\n",

                "\n\t As you approach the village, you call for help.\n" +
                "\t Tsunade meets you infront of Konoha Hospital \n" + 
                "\t and instantly brings Hanare in for care... \n " +
                "\n\t You have waited hours for the medical-nin to heal Hanare. \n" + 
                "\t Suddenly you hear Hanares voice...\n\n",

                "\t “Thank you {player.name}! You rescued me“ \n" +
                "\t “I knew you would find me, THANK YOU MY HERO!” \n\n",
                
                "\t You rescued Hanare and the peace is restored in The Hidden Leaf Village \n " +
                "\n\t THE END... \n\n",

                "\t CREDITS: \n" +
                "\t Kakashi Hatake - Robin Kamo\n" +
                "\t Campus Mölndal\n" +
                "\t Every cool person who has shared 8bit music\n" +
                "\t Youtube fabvl – Kakashi Rap Song Athousan.\n" +
                "\t Youtube suferas - Naruto - Sadness and Sorrow 8 Bit\n" +
                "\t Youtube Otaku Bits - Naruto Shippuden opening 3 - Blue Bird (8bit)\n" +
                "\t Youtube Musikage - Naruto Opening 2 - Haruka Kanata 8-bit NES Remix\n" +
                "\t Youtube 8 Bit Music Worl - Naruto - The Raising Fighting Spirit (8 bit)\n\n" +
                "\t CREATORS\n" +
                "\t Daudi - David Ström \n" +
                "\t Hocke - Håkan Eriksson"
                };
                foreach (var item in stories)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
                //return stories;
            }





            // @"..\..\..\..\HiddenLeafVillage.Wav
            // player.Play();
            // player.LoadAsync();
            // ”” söta för tal senare
            //Console.WriteLine("\t After fighting BossensNamn for hours you finally wear him down and kill him. \n" +
            //                  "\t As you dry the {BossensNamn} blood of your {player.weapon.namn} on his now torn up Flack jacket" +
            //                  "\n\t" +
            //                  "\n\t You hear faint sounds further into the cave and you sense it must be Hanare!\n " + 
            //                  "\n\t As you walked further into the huge cave system Hanares sounds get louder.");
            //Console.WriteLine("\t You are closing in on her!");
            //Console.WriteLine("\t As you walk further into the cave towards where you last heard Hanare \n" +
            //                  "\t You sense danger and instinctivly make a Shinobi backflip \n" +
            //                  "\n\t You manage to dodge the sword that was beeing aimed at your back! \n" +
            //                  "\n\t You knew it! It is the filty backstabbing Akatsuku Clan! \n" +
            //                  "\n\t Nobody else would ever try to kill a Shinobi from behinde." +
            //                  "\n\t Three Akatsuku are attacking and they have you cornered. ");
            //Console.WriteLine("");
            //Console.WriteLine("\t Beeing a true ninjutsu hero you are draw your {player.weapon} and counter attack. \n" +
            //                  "\t The closest attacker throws a {kastkniv} aimed at your heart! \n" +
            //                  "\n\t You use your chakra and redirect the knife into on of the other dirty Akatsu scumbag's! ");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t This fight did not last longer then a few minutes. They where weak and in your way. \n" + 
            //                  "\t Now they are all very very dead...");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t You sense Hanare is close and you walk into one of the dark side tunnels...");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Your senses tells you that Hanare is not alone! \n" +
            //                 "\t Someone with the ability to hide his true powers are also present.");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Who is this, and how can he block your senses? \n");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t You feel that the enemy and Hanare is just around the next corner. \n" +
            //                 "\t As you draw your {player.weapon} and walk around the corner you se Hanare and him, HIM...");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t This is impossible... He is dead, you know you killed him and every last member of their Clan. \n" + 
            //                  "\t this cant be!?! Kakuzu's alive?");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Kakuzu laughs like a mad man when he sees your confusion -“HA HA HA HA“ \n" +
            //                  "\t -“Did you not know that I teamed up with Orihime Inoue years ago? YOU FOOL!“ \n" +
            //                  "\t -“Orihime brought me back from the dead not more then 30 minutes after you left! \n" +
            //                  "\t -“She truly is special my dear Orihime...“");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t -“You should have killed her when you had the chance!“ \n" + 
            //                  "\t -“Instead I will now kill someone near and dear to you! \n" +
            //                  "\t -“I want you to watch me kill Hanare before I come back and kill you to!” ");
            //Console.WriteLine("\t -“GRAB HIM!!!“");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t You are suddenly overwhelmed from behinde by enemies pulling you down towards the ground, \n" +
            //                  "\t where did they come from!? Kakuzu must have used his {ability} to block my senses!");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Well, if this how he wants to play, fine by me! \n" +
            //                  "\t -“You shall meet your own powers you fool!“ \n" +
            //                  "\t You remove your forhead protector and use your sharingan! \n" +
            //                  "\n\t Your insight in Kakuzu's powers makes you block his senses \n" + 
            //                  "\t and he has no idea that you are approaching him. Until its to late... ");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t “The rage {players.name} unleashed upon Kakuzu has never been seen from any Shinobi \n" + 
            //                  "\t A true Shinobi are known to keep their cool even when angry! \n" +
            //                  "\t The tale of this fight will live on as a tale forever...“");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t As you come to your senses you rush to Hanare and untie the ropes around her hands and neck \n" +
            //                  "\t she is still unconscious and very very weak. \n " +
            //                  "\t without a second of rest you pick Hanare up and carry her all the way back to The Hidden Leaf Village.");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\n\t As you approach the village, you scream for help.");
            //Console.WriteLine("\t Tsunade meets you infront of Konoha Hospital and instantly brings Hanare in for care...");
            //Console.WriteLine("\n\t You have waited hours for the medical-nin to heal Hanare when you suddenly hear Hanares voice.");
            //Console.WriteLine("\t -“Thank you {player.name}! You rescued me“ \n" +
            //                  "\t -“I knew you would find me, THANK YOU HERO!”");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t The peace is back in The Hidden Leaf Village");
            //Console.WriteLine("\t The End...");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t CREDITS:");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Robin Kakashi Efternamn");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Campus Mölndal Who made this possible");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Every cool person who has shared music online");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Youtube fabvl – Kakashi Rap Song Athousan.");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Youtube suferas - Naruto - Sadness and Sorrow 8 Bit");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Youtube Otaku Bits - Naruto Shippuden opening 3 - Blue Bird (8bit)");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Youtube Musikage - Naruto Opening 2 - Haruka Kanata 8-bit NES Remix");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t Youtube 8 Bit Music Worl - Naruto - The Raising Fighting Spirit (8 bit)");
            //Console.WriteLine("\t ");
            //Console.WriteLine("\t CREATORS");
            //Console.WriteLine("\t Daudi - David Ström");
            //Console.WriteLine("\t Hocke - Håkan Eriksson");


            //Console.ReadLine();



            //soundLocation = Environment.CurrentDirectory + @"C:\test\FightFinal.wav";
            //player = new SoundPlayer(@"C:\test\FightFinal.wav");
            //player.Play();
            //player.LoadAsync();
            //Console.ReadLine();

            //soundLocation = Environment.CurrentDirectory + @"C:\test\TreasureFinal10db.wav";
            //player = new SoundPlayer(@"C:\test\TreasureFinal10db.wav");
            //player.Play();
            //player.LoadAsync();
            //Console.ReadLine();

            //soundLocation = Environment.CurrentDirectory + @"C:\test\AbuHassanFinal.wav";
            //player = new SoundPlayer(@"C:\test\AbuHassanFinal.wav");
            //player.Play();
            //player.LoadAsync();
            //Console.ReadLine();

            //soundLocation = Environment.CurrentDirectory + @"C:\test\FightFinal.wav";
            //player = new SoundPlayer(@"C:\test\FightFinal.wav");
            //player.Play();
            //player.LoadAsync();
            //Console.ReadLine();
            //soundLocation = Environment.CurrentDirectory + @"C:\test\NarutoGeneralFinal.wav";
            //player = new SoundPlayer(@"C:\test\NarutoGeneralFinal.wav");
            //player.Play();
            //player.LoadAsync();
            //Console.ReadLine();

        }
        
    }
}
