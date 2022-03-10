using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 namespace RNEA.Models
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException Vod(int n)
        {
            RomanNumberException nol = null;
            try
            {

                if (n > 1000) throw new Exception("Ошибка: Недопустимое значение, число должно быть меньше 1000");
                else throw new Exception("Ошибка: Недопустимое значение, число должно быть больше 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nol;

        }


    }

}

