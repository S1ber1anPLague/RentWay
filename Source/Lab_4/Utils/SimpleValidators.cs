using System.Linq;

namespace Lab_4.Utils
{
    public static class SimpleValidators
    {
        /// <summary>
        /// Проверка строки по шаблону: 
        /// Идентификатор паспорта состоит из 4-ех циферной серии и 6-циферного номера 
        /// [xxxxxxxxxx]
        /// </summary>
        /// <param name="passport"></param>
        /// <returns></returns>
        public static bool Passport(string passport)
        {
            if (string.IsNullOrWhiteSpace(passport))
            {
                return false;
            }
            
            if (passport.Length != 10)
            {
                return false;
            }

            return passport.All(char.IsDigit);
        }

        /// <summary>
        /// Номер телефона, к слову, состоит также из 10 цифр: 
        /// [+7(xxx)xxxxxxx]
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static bool Phone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }

            if (phone.Length != 12)
            {
                return false;
            }

            return
                 phone[0] == '+' && phone[1] == '7' && phone.Skip(2).All(char.IsDigit);
        }
    }
}
