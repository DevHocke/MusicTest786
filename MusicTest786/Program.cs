using System;
using System.Media;
using System.Reflection;
using System.Threading;

namespace MusicTest786
{
    class Program
    {
        static void Main(string[] args)
        {    
            var soundLocation = Environment.CurrentDirectory + @"C:\test\KakashiFightSongUP3.wav"; 
            SoundPlayer player = new SoundPlayer(@"C:\test\KakashiFightSongUP3.wav");
            player.PlayLooping();
            // player.Play();
            // player.LoadAsync();
            // ”” söta för tal senare
            Console.WriteLine("\t After fighting BossensNamn for hours you finally wear him down and kill him. \n" +
                              "\t As you dry the { BossensNamn} blood of your { player.weapon.namn} on his now torn up Flack jacket" +
                              "\n\t" +
                              "\n\t You hear faint sounds further into the cave and you sense it must be Hanare!\n " + 
                              "\n\t As you walked further into the huge cave system her sounds get louder, you are closing in on her.");

            Console.WriteLine("\t As you dry the {BossensNamn} blood of your {player.weapon.namn}on his dead corpses torn up");
            Console.WriteLine("\t Flack jacket. You hear faint sounds further into the cave and you sense it must be Hanare!");
            Console.WriteLine("");
            Console.WriteLine("\t As you walked further into the huge cave system her sounds get louder, you are closing in on her.");
            Console.WriteLine("");
            Console.WriteLine("\t You sense danger and instinctivly make a Shinobi backflip \n" +
                               "\t You manage to dodge the sword that was beeing aimed at your back! \n" +
                              "\n\t You knew it was the filty backstabbing  Akatsuku Clan! \n" +
                              "\n\t nobody else would ever try to kill a Shinobi from behinde." +
                              "\n\t Three Akatsuku are attacking and they have you cornered. ");
            Console.WriteLine("");
            Console.WriteLine("\t Beeing a true ninjutsu hero you are draw your {player.weapon} and counter attack. \n" +
                              "\t The closest attacker throws a {kastkniv} aimed at your heart! \n" +
                              "\t You use your chakra and redirect the knife into on of the other dirty Akatsu scumbag's! ");
            Console.WriteLine("\t ");
            Console.WriteLine("\t This fight did not last longer then a few minutes. They where weak and in your way. \n" + 
                              "\t Now they are all very very dead...");
            Console.WriteLine("\t ");
            Console.WriteLine("\t You sense Hanare is close and you walk into one of the dark side tunnels...");
            Console.WriteLine("\t ");
            Console.WriteLine("\t Your senses tells you that Hanare is not alone! \n" +
                             "\t Someone with the ability to hide his true powers are also present.");
            Console.WriteLine("\t ");
            Console.WriteLine("\t Who is this, and how can he block your senses? \n");
            Console.WriteLine("\t ");
            Console.WriteLine("\t You feel the person and Hanare is just around the next corner. \n" +
                             "\t As you draw your {player.weapon} and walk around the corner you se Hanare and him, HIM...");
            Console.WriteLine("\t ");
            Console.WriteLine("\t This is impossible... He is dead, you know you killed him and every last member of their Clan, this cant be!?!\n" +
                             "\t Kakuzu's alive?");
            Console.WriteLine("\t ");
            Console.WriteLine("\t ");
            Console.WriteLine("\t Kakuzu laughs like a mad man when he sees your confusion -“HA HA HA HA“ \n" +
                              "\t -“Did you not know that I teamed up with Orihime Inoue years ago? YOU FOOL!“ \n" +
                              "\t -“She healed me not more then 30 minutes after you left! She is incredible my dear Orihime... “");
            Console.WriteLine("\t ");
            Console.WriteLine("\t “You should have killed her when you had the chance, instead I will kill someone near and dear to you and make you watch me do it before I come back and deal with you!” ");
            Console.WriteLine("\t ");
            Console.WriteLine("\t “GRAB HIM!!!“  You are suddenly overwhelmed buy enemies pulling you down towards the ground, where did they come from!? Kakuzu must have used his {ability}to block my senses!");
            Console.WriteLine("\t ");
            Console.WriteLine("\t Well, if this how he wants to play, fine by me! You shall meet your own powers you fool, you remove your forhead protector and use your sharingan, your insight in his powers makes you block his senses that you are approaching him until its to late. ");
            Console.WriteLine("\t ");
            Console.WriteLine("\t The fury {players.name} unleashed upon Kakuzu has never been seen from any Shinobi who are know to keep their cool even when angry. The tale of this fight will live on forever…");
            Console.WriteLine("\t ");
            Console.WriteLine("\t As you come to your senses you rush to Hanare and untie the ropes around her hands and neck, she is still medvetslös (tilt...)  and very weak, you pick her up and carry her all the way back to The Hidden Leaf Village without a second of rest.");
            Console.WriteLine("\t ");
            Console.WriteLine("\t You scream for help and Tsunade meets you in the door of the Konoha Hospital. You have waited hours for the medical-nin to heal Hanare when you suddenly hear Hanares voice.");
            Console.WriteLine("\t ");
            Console.WriteLine("\t “Thank you {player.name}! You rescued me, I knew you would find me, ”THANK YOU!” The peace back in The Hidden Leaf Village ");
            Console.WriteLine("\t ");
            Console.WriteLine("\t The End...");

            Console.WriteLine("\t CREDITS:");
            Console.WriteLine("\t Robin Kakashi Efternamn");
            Console.WriteLine("\t Campus Mölndal Who made this possible");
            Console.WriteLine("\t Every cool person who has shared music online");
            Console.WriteLine("\t Youtube fabvl – Kakashi Rap Song Athousan.");
            Console.WriteLine("\t Youtube suferas - Naruto - Sadness and Sorrow 8 Bit");
            Console.WriteLine("\t Youtube Otaku Bits - Naruto Shippuden opening 3 - Blue Bird (8bit)");
            Console.WriteLine("\t Youtube Musikage - Naruto Opening 2 - Haruka Kanata 8-bit NES Remix");
            Console.WriteLine("\t Youtube 8 Bit Music Worl - Naruto - The Raising Fighting Spirit (8 bit)");
            Console.WriteLine("\t CREATORS");
            Console.WriteLine("\t Daudi - David Ström");
            Console.WriteLine("\t Hocke - Håkan Eriksson");


            Console.ReadLine();



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
