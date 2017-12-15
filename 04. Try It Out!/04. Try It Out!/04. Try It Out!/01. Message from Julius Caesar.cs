/*
Message from Julius Caesar
Encryption is the process of taking data and turning it into a form that is no longer readable . This 
keeps the information protected, so that people who aren’t supposed to read it can’t. Of course, the 
person who is supposed to read it needs to be able to decrypt it and recover the message.
When encryption is done, the algorithm used to encrypt stuff usually uses a special value called a 
key to perform the encryption. If a person has the key, they can usually decrypt the message as well.
The Caesar cipher is one of the simplest encryption schemes, and it is possibly something you used 
to send coded messages to friends when you were younger. It is an encryption method that
supposedly Julius Caesar occasionally used when he wrote personal letters.
The basic idea is that for every letter in your message, you shift it down the alphabet by a certain 
number of letters. The amount you shift is the key for the algorithm. If you are using a key of 3, A 
would become D, B would become E, etc. Once you get to the end of the alphabet, it wraps back 
around, so Z would be C.
For example, with a key of 4, the message below is encrypted to look like this:
Plain text: EXPERIENCE IS THE TEACHER OF ALL THINGS
Encrypted:  IBTIVMIRGI MW XLI XIEGLIV SJ EPP XLMRKW
Write a program that will read in a message from a file (or from the user) and encrypt it, writing out 
the encrypted message to another file (or back to the console window). Don’t overwrite the original 
file. Ideally, your program will ask for the name of a file to read, and a key (a number) to use in the 
encryption.
Anything besides a letter (punctuation, numbers, etc.) can either be skipped or passed along to the 
output without encrypting it.
Also create code that will do the reverse, decrypting a message given a decryption key.
If you want an extra challenge, try this. The Caesar cipher is really easy to crack. In fact, it is so basic 
that it provides little real protection in modern usage. Much more sophisticated algorithms are used 
now to encrypt data. To prove the point that the Caesar cipher can be cracked, we’ re going to try a 
“brute force” approach to crack the following code:
UX LNKX MH WKBGD RHNK HOTEMBGX
With the Caesar cipher, there are only 26 possible keys. Try each one, one at a time, until the 
decrypted message makes sense. The simple approach for this is to have a human (you) visually 
inspect the decrypted message to see if it makes sense. While it is more work, it is possible to have 
the computer figure out if the message has been decrypted by using a dictionary file (containing all 
or the words in the English language) and checking to see if all or most of the decrypted words are in 
it. A high percentage typically indicates a successful decryption.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Try_It_Out_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to file:");
            string path = Console.ReadLine();
            string text = System.IO.File.ReadAllText($@"{path}");
            Console.WriteLine("Enter key:");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to encode or decode the message?");
            string answer = Console.ReadLine();
            while (true)
            {
                if (answer.Equals("encode"))
                {
                    EncodeMessage(text, key);
                    break;
                }
                else if (answer.Equals("decode"))
                {
                    DecodeMessage(text, key);
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                    answer = Console.ReadLine();
                }
            }
           

        }

        public static void DecodeMessage(string message, int key)
        {
            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    if (Convert.ToInt32(message[i]) - key < 65)
                    {
                        decoded.Append(Convert.ToChar(Convert.ToInt32(message[i]) - key + 90 - 64));
                    }
                    else
                    {
                        decoded.Append(Convert.ToChar(Convert.ToInt32(message[i]) - key));
                    }
                }
                else
                {
                    decoded.Append(message[i]);
                }
            }

            Console.WriteLine("Plain text: " + message);
            Console.WriteLine("Decrypted: " + decoded.ToString());
        }
        public static void EncodeMessage(string message, int key)
        {
            StringBuilder encoded = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    if (Convert.ToInt32(message[i]) + key > 90)
                    {
                        encoded.Append(Convert.ToChar(Convert.ToInt32(message[i]) + key - 90 + 64));
                    }
                    else
                    {
                        encoded.Append(Convert.ToChar(Convert.ToInt32(message[i]) + key));
                    }
                }
                else
                {
                    encoded.Append(message[i]);
                }
            }

            Console.WriteLine("Plain text: " + message);
            Console.WriteLine("Encrypted: " + encoded.ToString());
        }
    }
}
