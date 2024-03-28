using System.ComponentModel.Design;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CustomWord("salam", 'a')); ;
            //Console.WriteLine(Toupper("salam"));
            //string a = "ice";
            //string b = "cube";
            //Console.WriteLine(a+" "+b);
            Console.WriteLine(Startwith("ice"));
           

        }
        //static int CustomWord(string word,char letter)
        //{
        //    for(int i=word.Length-1; i>0; i--)
        //    {
        //        if (word[i] == letter)  
        //        {
        //            return i;
        //        }
        //    }

        //    return -1;
        //}
        //static string Toupper(string word)
        //{
        //    string newstr="";
        //    for(int i=0; word.Length > i;i++)
        //    {
        //        if ((word[i] >= 'a') && (word[i] <= 'z'))
        //        {
        //            newstr += (char)(word[i] - 32);
        //        }   
        //    }return newstr;
        //}
        static bool Startwith(string word)
        {       
            string str = "icecube";
          for(int i=0; i<word.Length; i++)
            {
                if (word[i] == str[i])
                {
                 return true;
                }
            }
        }
    }
}