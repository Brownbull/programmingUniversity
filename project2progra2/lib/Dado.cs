using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Dado
    {
        private static Random _random = new Random();
        private int _value;

        public Dado(Dado copy)
        {
            Value = copy.Value;
            Random = new Random();
        }

        public Dado(int value)
        {
            Value = value;
        }

        public Dado()
        { }

        public static Random Random
        {
            get
            {
                return _random;
            }

            set
            {
                _random = value;
            }
        }

        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public void Roll()
        {
            Value = Random.Next(1,6);
        }
    } // end of class Dado
}
