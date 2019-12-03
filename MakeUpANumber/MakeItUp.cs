using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpANumber
{
    class MakeItUp : IMakeItUp
    {
        public List<string> getAnswers(int[] numberList, int solution)
        {

            List<string> stringList = new List<string>(); // String[numberList.Length * 2];
            for (int i = 0; i < numberList.Length; i++)
            {
                if (numberList[i] == solution)
                {
                    stringList.Add($"{numberList[i]}");
                }
                if (i != (numberList.Length - 1))
                {
                    for (int j = i+1; j <numberList.Length; j++)
                    {
                        if (numberList[i] + numberList[j] == solution)
                        {
                            stringList.Add($"{numberList[i]} ,{numberList[j]}");
                        }
                    }
                }
            }
           

            return stringList;
        }
        public List<string> recursionfunc(int solution, int[] numArray,List<string> strings, int iterations, int currentSum, int[] stage) {

            int depth = numArray.Length - iterations;
            int sum;
            //int[] stage2 = new int[numArray.Length];
            
            for (int i = depth; i < numArray.Length; i++)
            {
               // Console.WriteLine($"depth={depth},iteration={i}");
                stage[depth] = i;
                string tempString2 = "";
                for (int j = 0; j <= depth; j++)
                {
                    tempString2 = ($"{tempString2},{numArray[stage[j]]}");
                }
                //Console.WriteLine(tempString2);
                //Console.WriteLine($"--------------------");
                sum = currentSum + numArray[i];
                if (sum == solution)
                {
                    String tempString = "";
                    bool repeats = false;
                    if (depth != 0)
                    {
                        if (stage[depth - 1] == stage[depth])
                        {
                            repeats = true;
                        }
                    }
                    for (int j = 0; j < depth-1; j++)
                    {
                        for (int k = j + 1; k < depth; k++)
                        {
                            if (stage[j] == stage[k])
                            {
                                repeats = true;
                            }
                        }
                    }
                    if (!repeats)
                    {
                        //Console.WriteLine("TRUE!!!");
                        strings.Add(tempString2);
                    }
                }
                recursionfunc(solution, numArray, strings, iterations - 1, sum, stage);
                //iterations ++;
            }
            return strings;
        } 
    }
}
