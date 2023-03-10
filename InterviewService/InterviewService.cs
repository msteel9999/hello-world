using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Interview.Services
{
    public class InterviewService
    {
        //Task 1
        public String SimpleReverse(String input)
        {
            var inputWords = input.Split(' ');
            Array.Reverse(inputWords);
            return string.Join(" ", inputWords);
        }

        //Task 2
        public double GetAverageEvenNumberOfObjects(List<object> objects)
        {
            var count = 0;
            var sum = 0.0;

            foreach (var obj in objects)
            {
                if (!(obj is int)) continue;

                var number = (int)obj;
                if (number % 2 != 0) continue;
                count++;
                sum += number;
            }

            return count == 0 ? 0.0 : sum / count;
        }

        //Task 3
        public string ReverseWithPunctuation(string input)
        {
            var wordsAndPunctuation = Regex.Split(input, @"(\W)");
            Array.Reverse(wordsAndPunctuation);

            var sb = new StringBuilder();
            var capitaliseNext = false;

            foreach (var s in wordsAndPunctuation)
            {
                var changedS = s;
                if (capitaliseNext && changedS.Length > 0)
                {
                    changedS = changedS[0].ToString().ToUpper();
                    if(s.Length > 1)
                    {
                        changedS += s.Substring(1);
                    }      
                    capitaliseNext = false;
                }
                else
                {
                    changedS = changedS.ToLower();
                }

                if (IsPunctuation(s)) 
                {
                    capitaliseNext = true;
                }

                sb.Append(changedS);
            }

            return sb.ToString();
        }

        private static bool IsPunctuation(string s)
        {
            return s.Length == 1 && !char.IsLetterOrDigit(s[0]) && !string.IsNullOrWhiteSpace(s);
        }
    }
}