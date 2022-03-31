using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3.Models
{
    public class BinaryN
    {
        long number = default(long);
        public long Number => number;
        public BinaryN(string input)
        {
            number = Convert.ToInt64(input,2);
        }
        public static BinaryN operator+(BinaryN current, BinaryN add)
        {
            var addResult = current.Number + add.Number;
            return new BinaryN(Convert.ToString(addResult,2));
        }

        public static BinaryN operator -(BinaryN current, BinaryN add)
        {
            var addResult = current.Number - add.Number;
            return new BinaryN(Convert.ToString(addResult, 2));
        }

        public static BinaryN operator *(BinaryN current, BinaryN add)
        {
            var addResult = current.Number * add.Number;
            return new BinaryN(Convert.ToString(addResult, 2));
        }

        public static BinaryN operator /(BinaryN current, BinaryN add)
        {
            var addResult = current.Number / add.Number;
            return new BinaryN(Convert.ToString(addResult, 2));
        }

        public override string ToString()
        {
            return Convert.ToString(number,2);
        }
    }
}
