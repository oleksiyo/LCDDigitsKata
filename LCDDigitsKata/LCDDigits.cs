using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using NSubstitute;
using ApprovalTests.Reporters;
using ApprovalTests;
using System.Text.RegularExpressions;

namespace LCDDigitsKata
{
    public class LCDDigits
    {
        public String ToLCD(int digit)
        {
            var numbers = GetDigits(digit);
            return ConvertToLCDSymbols(numbers);
        }

        // TODO: refactoring!!!
        private string ConvertToLCDSymbols(string[] digits)
        {
            var result = string.Empty;
            var list = new List<string>();

            var dic = GroupLCDSymbolsByDigits(digits);

            var step = 3;
            for (var l = 0; l < step; l++)
            {
                list.AddRange(dic.Select(x => dic.Count > 1 ? x.Value[l] + " " : x.Value[l]));
                list[list.Count - 1] = list[list.Count - 1].TrimEnd();
                list.Add("\n");
            }
            result = string.Join("", list);
            return result.Substring(0, result.Length - 1); 
        }

        private Dictionary<int, List<string>> GroupLCDSymbolsByDigits(string[] digits)
        {
            var result = new Dictionary<int, List<string>>();
            foreach (var item in digits)
                result.Add(result.Count, LCDSymbols.symbols.Single(x => x.Key.ToString() == item).Value.ToList());

            return result;
        }

        private string[] GetDigits(int number)
        {
            return (Regex.Replace(number.ToString(), "(?!^).{1}", " $0", RegexOptions.RightToLeft)).Split(new String[] { " " }, StringSplitOptions.None);
        }
    }

    public class LCDDigitsTest
    {
        LCDDigits lcdDigits;

        public LCDDigitsTest()
        {
            lcdDigits = new LCDDigits();
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_0()
        {
            var result = lcdDigits.ToLCD(0);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_1()
        {
            var result = lcdDigits.ToLCD(1);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_2()
        {
            var result = lcdDigits.ToLCD(2);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_3()
        {
            var result = lcdDigits.ToLCD(3);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_4()
        {
            var result = lcdDigits.ToLCD(4);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_5()
        {
            var result = lcdDigits.ToLCD(5);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_6()
        {
            var result = lcdDigits.ToLCD(6);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_7()
        {
            var result = lcdDigits.ToLCD(7);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_8()
        {
            var result = lcdDigits.ToLCD(8);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_9()
        {
            var result = lcdDigits.ToLCD(9);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_19()
        {
            var result = lcdDigits.ToLCD(19);
            Approvals.Verify(result);
        }

        [Fact]
        [UseReporter(typeof(DiffReporter))]
        public void should_return_lcd_190()
        {
            var result = lcdDigits.ToLCD(190);
            Approvals.Verify(result);
        }
    }
}
