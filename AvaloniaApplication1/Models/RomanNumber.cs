using System;
using System.Text;
using RNEA.Models;
using System.Collections.Generic;


namespace RNA.Models
{
    public class RomanNumber : ICloneable, IComparable
    {
        string number;
        public int value;

        public RomanNumber(int n)
        {
            try
            {
                if (n < 0 || n > 1000)
                    throw new ArgumentException("Value must be in the range 0 - 1000.");
                RomanNumberException cvb = new RomanNumberException();
                if (n == 0 || n < 0) cvb.Vod(n);

                ushort[] values = new ushort[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] numerals = new string[]
                { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


                StringBuilder result = new StringBuilder();


                for (int i = 0; i < 13; i++)
                {
                    while (n >= values[i])
                    {
                        n -= values[i];
                        result.Append(numerals[i]);
                    }
                }
                number = result.ToString();
                Console.WriteLine(result.ToString());
            }

            catch
            {
                if (n > 1000) throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть меньше 1000");
                else throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть больше 0.");
            }

        }


        public static RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)
        {
            int sum3 = 0;
            RomanNumber number1;
            try
            {
                string a1 = n1.number;
                char[] arr1 = new char[a1.Length];
                arr1 = a1.ToCharArray();
                int sum1 = 0;
                Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum1 += rimDg1[arr1[i]];
                }

                string a2 = n2.number;
                char[] arr2 = new char[a2.Length];
                arr2 = a2.ToCharArray();
                int sum2 = 0;
                Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr2.Length; i++)
                {
                    sum2 += rimDg2[arr2[i]];
                }

                sum3 = sum1 + sum2;

                Console.WriteLine(sum3);
                number1 = new RomanNumber(sum3) { value = sum3 };
            }
            catch
            {
                if (sum3 > 1000) throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть меньше 1000");
                else throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть больше 0.");
            }
            return new RomanNumber(number1.value) { value = number1.value };
        }


        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            int min3 = 0;
            RomanNumber number2 = null;
            try
            {
                string a1 = n1.number;
                char[] arr1 = new char[a1.Length];
                arr1 = a1.ToCharArray();
                int min1 = 0;
                Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr1.Length; i++)
                {
                    min1 += rimDg1[arr1[i]];
                }

                string a2 = n2.number;
                char[] arr2 = new char[a2.Length];
                arr2 = a2.ToCharArray();
                int min2 = 0;
                Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr2.Length; i++)
                {
                    min2 += rimDg2[arr2[i]];
                }

                min3 = min1 - min2;

                if (min3 > 0)
                {
                    Console.WriteLine(min3);
                    number2 = new RomanNumber(min3) { value = min3 };
                }
                else
                {
                    RomanNumberException error = new RomanNumberException();
                    error.Vod(min3);
                }
            }
            catch
            {
                if (min3 > 1000) throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть меньше 1000");
                else throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть больше 0.");
            }

            return new RomanNumber(number2.value) { value = number2.value };

        }

        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            int mul3 = 0;
            RomanNumber number3 = null;
            try
            {
                string a1 = n1.number;
                char[] arr1 = new char[a1.Length];
                arr1 = a1.ToCharArray();
                int mul1 = 0;
                Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr1.Length; i++)
                {
                    mul1 += rimDg1[arr1[i]];
                }

                string a2 = n2.number;
                char[] arr2 = new char[a2.Length];
                arr2 = a2.ToCharArray();
                int mul2 = 0;
                Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr2.Length; i++)
                {
                    mul2 += rimDg2[arr2[i]];
                }

                mul3 = mul1 * mul2;

                if (mul3 < 1000)
                {
                    Console.WriteLine(mul3);
                    number3 = new RomanNumber(mul3) { value = mul3 };
                }
                else
                {
                    RomanNumberException error = new RomanNumberException();
                    error.Vod(mul3);
                }


            }
            catch
            {
                if (mul3 > 1000) throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть меньше 1000");
                else throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть больше 0.");
            }

            return new RomanNumber(number3.value) { value = number3.value };
        }

        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {
            int div3 = 0;
            RomanNumber number4;
            try
            {
                string a1 = n1.number;
                char[] arr1 = new char[a1.Length];
                arr1 = a1.ToCharArray();
                int div1 = 0;
                Dictionary<char, int> rimDg1 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr1.Length; i++)
                {
                    div1 += rimDg1[arr1[i]];
                }

                string a2 = n2.number;
                char[] arr2 = new char[a2.Length];
                arr2 = a2.ToCharArray();
                int div2 = 0;
                Dictionary<char, int> rimDg2 = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
                for (int i = 0; i < arr2.Length; i++)
                {
                    div2 += rimDg2[arr2[i]];
                }

                div3 = div1 / div2;

                Console.WriteLine(div3);
                number4 = new RomanNumber(div3) { value = div3 };
            }
            catch
            {
                if (div3 > 1000) throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть меньше 1000");
                else throw new NotImplementedException("Ошибка: Недопустимое значение, число должно быть больше 0.");
            }

            return new RomanNumber(number4.value) { value = number4.value };

        }

        public override string ToString()
        {

            throw new NotImplementedException("The method or operation is not implemented.");
        }

        public object Clone()
        {

            try
            {
                return new RomanNumber(value);
            }
            catch
            {
                throw new NotImplementedException("The method or operation is not implemented.");
            }

        }

        public int CompareTo(object? obj)
        {
            try
            {
                if (obj is RomanNumber person) return value.CompareTo(person.value);
                else throw new ArgumentException("Вы ввели некорректное значение параметра");
            }
            catch
            {
                throw new NotImplementedException("The method or operation is not implemented.");
            }

        }




    }

}

