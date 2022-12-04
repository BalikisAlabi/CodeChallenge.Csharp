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
          string text = "AfricanJournal";
          System.Console.WriteLine(decode(text));
        }
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
          if (i % 2 != 0)
          {
            even += first[i];
            even +=second[i];
          }         
        }
        even += second[second.Length-1];
        //return even + odd;
        System.Console.WriteLine(even+odd);
          Char[] first1 = odd.ToCharArray();  
          Char[] second1 = even.ToCharArray();     
          string odd1 = "";
          string even1 = "";    
            for(int i = 0; i < first1.Length-1; i++)
            { 
                if (i % 2 == 0)
                {
                    odd1 += first1[i];
                    odd1 +=second1[i];   
                }
            }
            odd1 += first1[first1.Length-1];

            for(int i = 0; i < second1.Length-1; i++)
            {  
                if ( i % 2 != 0)
                {
                    even1 += first1[i];
                    even1 +=second1[i];   
                }
            }
            even1 += second1[second1.Length-1];
        return odd1 + even1;      
    }  

    }
}