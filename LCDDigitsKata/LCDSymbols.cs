using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCDDigitsKata
{
    public static class LCDSymbols
    {
        const string topDot = "...";
        const string topDash = "._.";
        const string bothDash = "|.|";
        const string leftDash = "..|";
        const string rightCorn = "._|";
        const string fullDash = "|_|";
        const string leftCorn = "|_.";

      public static readonly  Dictionary<int, string[]> symbols = new Dictionary<int, string[]> 
            { 
                {0, new string[]{topDash,bothDash,fullDash}},
                {1, new string[]{topDot, leftDash, leftDash}},
                {2, new string[]{topDash,rightCorn,leftCorn}},
                {3, new string[]{topDash,rightCorn,rightCorn}},
                {4, new string[]{topDot, fullDash, leftDash}},
                {5, new string[]{topDash,leftCorn,rightCorn}},
                {6, new string[]{topDash,leftCorn,fullDash}},
                {7, new string[]{topDash, leftDash,leftDash}},
                {8, new string[]{topDash,fullDash,fullDash}},
                {9, new string[]{topDash,fullDash, leftDash}}
            };
    }
}
