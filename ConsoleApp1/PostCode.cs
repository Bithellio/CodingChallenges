using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PostCode
    {
        
        public static void RunPostCode()
        {
            Console.WriteLine("Please enter Postcode");
            var postcode = Console.ReadLine(); 

            if(postcode.Length < 5)
            {
                Console.WriteLine("PostCode is too short, Postcode should be at least 5 characters long Please Try Again");
                RunPostCode(); 
            }
            else
            {
                postcode = postcode.ToUpper();  // Convert to upper case 

                postcode.Replace(" ",""); // remove any spaces or whitespace in the post code 


                var innerCode = postcode.Substring(postcode.Length - 3); // last three chars should be the inner; 

                var outerCode = postcode.Substring(0, postcode.Length - 3); // the rest SHOULD be the outer code; 

                var intIndex = IndexOfFirstNumber(outerCode);

                if(intIndex == null)
                {
                    Console.Write("No numbers appear to be in outer code. please try again");
                    RunPostCode(); 
                }
                else
                {
                    var outerLetters = outerCode.Substring(0, (int)intIndex);
                    var outerNumbers = outerCode.Substring((int)intIndex);

                    Console.WriteLine(FormatPostcodeOutPut(postcode, outerLetters, outerNumbers, innerCode));
                    RunPostCode();

                                        
                }
            }  
        }



        private static int? IndexOfFirstNumber(string toCheck) 
        {
            var array = toCheck.ToCharArray(); 
            for(var i = 0;i < array.Length; i++ )
            {
                if(int.TryParse(array[i].ToString(),out int result)) // there is an overload that takes a char to check this but it seemed overkill for what i wanted 
                {
                    return i; 
                }
            }
            return null; // return null if no numbers are present
            
            
        }



        private static string FormatPostcodeOutPut(string postcode,string outwardLetter,string outwardNumber, string inwardCode)
        {
            var sb = new StringBuilder();
            var indent = "    ";   // using 4 spaces as indent
            sb.AppendLine($"# POSTCODE: {postcode}");
            sb.AppendLine($"{indent}OUTWARD CODE: {outwardLetter}{outwardNumber}");
            sb.AppendLine($"{indent}{indent}OUTWARD LETTER: {outwardLetter}");
            sb.AppendLine($"{indent}{indent}OUTWARD NUMBER: {outwardNumber}");
            sb.AppendLine($"{indent}INWARD CODE: {inwardCode}");
            return sb.ToString();
        }
    }
}
