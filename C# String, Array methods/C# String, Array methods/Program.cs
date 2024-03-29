using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        AntiBosluq("   salam,        dunya");
        Console.WriteLine(EdedReqem("Aw333had"));
        IlkSoz("salam   qwqw");
        int[] ints = { 1, 2, 3 };
        Console.WriteLine(Addnumber(ints,4));
        Console.WriteLine(Son("asas sasa"));
    }

    static void AntiBosluq(string input)
    {
       for (int i = 1; i < input.Length; i++)
        {   
            if (input[i] ==' '&& input[i-1] ==' ') continue;
            Console.Write(input[i]);
        }
    }
    static bool EdedReqem(string input)
    {
        bool reqem = false;
        bool boyukherf = false;
        bool kicikherf = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > 47 && input[i] < 58) { reqem = true; }
            else if (input[i] > 64 && input[i] < 91) { boyukherf = true; }
            else if ((input[i] > 96 && input[i] < 123)) { kicikherf = true; }


        }
        if (reqem && boyukherf && kicikherf) return true;

        return false;
    }
    static void IlkSoz(string input)
    {
        for (int i = 0; i < input.Length-1; i++)
        {
            if (input[i] == ' ')
            {
                break;
            }
            else if ( input[i + 1] == ' ' || input[i+1]!=' ')
            {
                Console.Write(input[i]);

            }
            else if (input[i] != ' '&& input[i+1]==' ') { break; }
        }
    }
    static int[] Addnumber(int[] input, int number)
    {
        int[] result = new int[input.Length+1];
        for (int i = 0;i < input.Length;i++)
        {
            result[i] += input[i];
            result[input.Length] = number;
        }
        

        return result;
    }
    static bool Son(string input )
    {
        int count=0;
        for(int i = 0; i < input.Length; i++)
        {
            if (input[i]==' ') { count++; }
        }
        if (count == 1) {  return true; } 
        return false;//boyuk herf shertine vaxt chatmadi
    }
    
        
    


}