using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace method
{
    public class Challenge
    {
      public static void Main()
        {
          Console.WriteLine("Enter your text to get encoded");
          //string text= encode(decode(Console.ReadLine())); 
          string text = "AfricanJournal";
          System.Console.WriteLine(encode(text));
          string code = encode(text);
          System.Console.WriteLine(decode(code));
        }
       static string encode(string text)
      {     
        Char[] first = text.Substring(0, text.Length/2).ToCharArray();
        Char[] second = text.Substring(text.Length/2).ToCharArray();
        string odd = "";
        string even = "";

        for(int i = 0; i < first.Length; i++)
        {
           if (i % 2 ==0)
           {
             odd += first[i];
             odd +=second[i];
           }
        }
        odd += first[first.Length-1];
        for(int i = 0; i < second.Length; i++)
        {
          if (i % 2 != 0)
          {
            even += first[i];
            even +=second[i];
          }         
        }
        odd += second[second.Length-1];
        return even + odd;
      }
      //even += second[second.Length-1];
       static string decode(string text)
        {
          Char[] first = text.Substring(0, text.Length/2).ToCharArray();
          Char[] second = text.Substring(text.Length/2).ToCharArray();       
          string odd = "";
          string even = "";    
            for(int i = 0; i < first.Length-1; i++)
            { 
                if (i % 2 == 0)
                {
                    odd += first[i];
                    odd +=second[i];   
                }
            }
            odd += first[first.Length-1];

            for(int i = 0; i < second.Length-1; i++)
            {  
                if ( i % 2! == 0)
                {
                    even += first[i];
                    even +=second[i];   
                }
            }
            even += second[second.Length-1];
        return odd + even;      
    }  

    }
}