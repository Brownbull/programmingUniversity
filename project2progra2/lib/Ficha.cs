using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class Ficha
    {
        private int _position;
        private string _type;

        public int Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public Ficha(Ficha copy)
        {
            Position = copy.Position;
            Type = copy.Type;
        }

        public Ficha(int position, string type)
        {
            Position = position;
            Type = type;
        }

        public Ficha(string type)
        {
            Type= type;
        }

        public Ficha(int position)
        {
            Position = position;
        }

        public Ficha()
        { }

        // Custom methods
        public void Move(int roll1, int roll2)
        {
            if (Type == "sapo")
            {
                Position = Position + (2 * (roll1 + roll2));
            }
            else
            {
                if (roll1 > roll2)
                {
                    Position = Position + roll2;
                }
                else
                {
                    Position = Position + roll1;
                }
            } // end of if (Type

        } // end of Move


    } // end of public class Ficha
} // end of namespace lib
