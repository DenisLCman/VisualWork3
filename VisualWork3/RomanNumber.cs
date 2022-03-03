using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualWork3
{
    public class RomanNumber : ICloneable, IComparable
    {
        readonly ushort number;

        public RomanNumber(ushort n)
        {
            if (n <= 0)
            {
                throw new RomanNumberException("Число будет не целым");
            }
            number = n;
        }
        public static RomanNumber operator +(RomanNumber n1, RomanNumber n2)
        {
            if (n1 is null || n2 is null) throw new RomanNumberException();
            return new RomanNumber((ushort)(n1.number + n2.number));
        }
        public static RomanNumber operator -(RomanNumber n1, RomanNumber n2)
        {
            if (n1 is null || n2 is null) throw new RomanNumberException();
            if (n1.number <= n2.number) throw new RomanNumberException("Результат будет отрицательный");
            return new RomanNumber((ushort)(n1.number - n2.number));
        }
        public static RomanNumber operator *(RomanNumber n1, RomanNumber n2)
        {
            if (n1 is null || n2 is null) throw new RomanNumberException();
            return new RomanNumber((ushort)(n1.number * n2.number));
        }
        public static RomanNumber operator /(RomanNumber n1, RomanNumber n2)
        {
            return new RomanNumber((ushort)(n1.number / n2.number));
        }
        public override string ToString()
        {
            return toRoman(number);
        }
        private static string toRoman(int number)
        {

            string tmp = "";
            while (number >= 1000)
            {
                tmp += "M";
                number -= 1000;
            }
            while (number >= 900)
            {
                tmp += "CM";
                number -= 900;
            }
            while (number >= 500)
            {
                tmp += "D";
                number -= 500;
            }
            while (number >= 400)
            {
                tmp += "CD";
                number -= 400;
            }
            while (number >= 100)
            {
                tmp += "C";
                number -= 100;
            }
            while (number >= 90)
            {
                tmp += "XC";
                number -= 90;
            }
            while (number >= 50)
            {
                tmp += "L";
                number -= 50;
            }
            while (number >= 40)
            {
                tmp += "XL";
                number -= 40;
            }
            while (number >= 10)
            {
                tmp += "X";
                number -= 10;
            }
            while (number >= 9)
            {
                tmp += "IX";
                number -= 9;
            }
            while (number >= 5)
            {
                tmp += "V";
                number -= 5;
            }
            while (number >= 4)
            {
                tmp += "IV";
                number -= 4;
            }
            while (number >= 1)
            {
                tmp += "I";
                number -= 1;
            }
            return tmp;
            throw new RomanNumberException();
        }

        public object Clone()
        {
            return new RomanNumber(number);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumber num) return number.CompareTo(num.number);
            else throw new RomanNumberException("Некорректное значение аргумента");
        }

    }
}