﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*2325. Decode the Message
     * You are given the strings key and message, which represent a cipher key and a secret message, respectively. The steps to decode message are as follows:

        Use the first appearance of all 26 lowercase English letters in key as the order of the substitution table.
        Align the substitution table with the regular English alphabet.
        Each letter in message is then substituted using the table.
        Spaces ' ' are transformed to themselves.
        For example, given key = "happy boy" (actual key would have at least one instance of each letter in the alphabet), we have the partial substitution table of ('h' -> 'a', 'a' -> 'b', 'p' -> 'c', 'y' -> 'd', 'b' -> 'e', 'o' -> 'f').
        Return the decoded message.
 
        Example 1:
        Input: key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv"
        Output: "this is a secret"
        Explanation: The diagram above shows the substitution table.
        It is obtained by taking the first appearance of each letter in "the quick brown fox jumps over the lazy dog".
    
        Example 2:
        Input: key = "eljuxhpwnyrdgtqkviszcfmabo", message = "zwx hnfx lqantp mnoeius ycgk vcnjrdb"
        Output: "the five boxing wizards jump quickly"
        Explanation: The diagram above shows the substitution table.
        It is obtained by taking the first appearance of each letter in "eljuxhpwnyrdgtqkviszcfmabo".

        Constraints:
        26 <= key.length <= 2000
        key consists of lowercase English letters and ' '.
        key contains every letter in the English alphabet ('a' to 'z') at least once.
        1 <= message.length <= 2000
        message consists of lowercase English letters and ' '.
    */
    public class clsDecodeTheMessage
    {
        public string DecodeMessage(string key, string message)
        {
            //USING CHAR ARRAY 
            char[] map = new char[26];
            char c = 'a';
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] != ' ' && map[key[i] - 'a'] == 0)
                    map[key[i] - 'a'] = c++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                    sb.Append(" ");
                else
                    sb.Append(map[message[i] - 'a']);
            }
            return sb.ToString();
            /*USING DICTIONARY
            Dictionary<char, char> dict = new Dictionary<char, char>();
            char c = 'a';
            for (int i = 0; i < key.Length && c <= 'z'; i++)
            {
                if (key[i] != ' ')
                {
                    if (!dict.ContainsKey(key[i]))
                        dict.Add(key[i], c++);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                    sb.Append(" ");
                else
                    sb.Append(dict[message[i]]);
            }
            return sb.ToString();
            */
        }
    }
}
