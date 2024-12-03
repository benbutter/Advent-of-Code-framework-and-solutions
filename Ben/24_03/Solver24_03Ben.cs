using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_2022._24_03
{
    public class Solver24_03Ben : ISolver
    {
        public string GetSolution(StreamReader streamReader)
        {
            //  var str = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";
            int total = 0;
            String str = "";
            bool dontMode = false;

            while (!streamReader.EndOfStream)
            {
                str = streamReader.ReadLine();




                var split = str.Split(new[] { "mul" }, StringSplitOptions.None);


                //   Console.ReadLine();
                foreach (var item in split)
                {
                    if (!dontMode)
                    {
                        total = total + GetProduct(item);
                    }
                    if (item.Contains("don't()"))
                    {
                        dontMode = true;
                    }
                    else if (item.Contains("do()"))
                    {
                        dontMode = false;
                    }
                }
            }
            return total.ToString();
          
        }

        //this is horrible and should be burnt
        public int GetProduct(string str)
        {
            string firstIntString = "";
            string secondIntString = "";
            int returnInt = 0;
            bool hitComma = false;

            for(int i = 0; i < str.Length; i++)
            {
                if (i == 0 )
                {
                    if (str[i] == '(')
                    {
                        continue;
                    }
                    else
                    {
                        return 0;
                    }
                }

                if (int.TryParse(str[i].ToString(), out returnInt ))
                {
                     if (hitComma)
                      {
                          secondIntString = secondIntString + returnInt.ToString();
                      }
                      else
                      {
                          firstIntString = firstIntString + returnInt.ToString();
                      }
                }

                else if (str[i] == ',')
                {
                    if (hitComma)
                    {
                        return 0;
                    }
                    else
                    {
                        hitComma = true;
                        continue;
                    }

                }
                else if (str[i] == ')')
                {
                    if (secondIntString == "")
                    {
                        return 0;
                    }
                    else
                    { break; }
                }
                else
                { return 0; }
            }
            
            Console.WriteLine(firstIntString + "," + secondIntString);
            return (int.Parse(firstIntString) * int.Parse(secondIntString)) ;
        }
    }
}
