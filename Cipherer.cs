using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_prakt
{
    internal class Cipherer
    {
        public static string cipherer(string text, string key)
        {
            int num;
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                num = ((int)text[i] + (int)key[i] - 64) % 96;
                newText += (char)(num + 32);
            }
            return newText;
        }

        public static string decipherer(string text, string key)
        {
            int num;
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                num = (((int)text[i] - 32) - ((int)key[i] - 32) + 96) % 96;
                newText += (char)(num + 32);
            }
            return newText;
        }

        public static string keyExtender(int num, string key)
        {

            while (num / key.Length > 1)
            {
                key += key;
            }

            int temp = num % key.Length;

            for (int i = 0; i < temp; i++)
            {
                key += key[i];
            }
            return key;
        }


    }
