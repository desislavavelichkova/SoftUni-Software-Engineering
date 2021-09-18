using System;
using System.Text.RegularExpressions;

namespace _2.SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z][a-z\'?]+\s*[a-z\'?]+):([A-Z]+\s*[A-Z]+)\b";

            string input = Console.ReadLine();
            
            while (input != "end")
            {
                Match match = Regex.Match(input, pattern);
                string artist = match.Groups[1].Value;
                string song = match.Groups[2].Value;
                int key = artist.Length;
                string encryptedArtist = "";
                string encryptedSong = "";

                for (int i = 0; i < artist.Length; i++)
                {
                    if ((artist[i] >= 65 - key && artist[i] <= 90 - key) || (artist[i] >= 97 - key && artist[i] <= 122 - key))
                    {
                        encryptedArtist += (char)(artist[i] + key);
                    }
                    else if (artist[i] > 90 - key || artist[i] > 122 - key)
                    {                        
                        encryptedArtist += (char)(artist[i] + key - 26);
                    }
                    else if ((char)artist[i] == 32)
                    {
                        encryptedArtist += " ";
                    }
                    else if ((char)artist[i] == 39)
                    {
                        encryptedArtist += "'";
                    }                    
                }
                for (int i = 0; i < song.Length; i++)
                {
                    if (song[i] >= 65 - key && song[i] <= 90 - key)
                    {
                        encryptedSong += (char)(song[i] + key);
                    }
                    else if (song[i] > 90 - key)
                    {
                        encryptedSong += (char)(song[i] + key - 26);
                    }
                    else if ((char)song[i] == 32)
                    {
                        encryptedSong += " ";
                    }
                    else if ((char)song[i] == 39)
                    {
                        encryptedSong += "'";
                    }
                }

                if (match.Success)
                {
                    Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
