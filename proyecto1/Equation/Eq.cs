using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class Eq
    {
        // factors on equation + Ax^2 + Bx + C = y
        private float _factorA;
        private float _factorB;
        private float _factorC;
        private int _symbolA;
        private int _symbolB;
        private int _symbolC;

        // Constructors
        public float FactorA
        {
            get { return _factorA; }
            set { _factorA = value; }
        }

        public float FactorB
        {
            get { return _factorB; }
            set { _factorB = value; }
        }

        public float FactorC
        {
            get { return _factorC; }
            set { _factorC = value; }
        }

        public int SymbolA
        {
            get { return _symbolA; }
            set { _symbolA = value; }
        }
        public int SymbolB
        {
            get { return _symbolB; }
            set { _symbolB = value; }
        }
        public int SymbolC
        {
            get { return _symbolC; }
            set { _symbolC = value; }
        }
        public Eq()
        { }

        // Custom Methods
        public void SetFactorsAndSymbols(float factorA, float factorB, float factorC, int symbolA, int symbolB, int symbolC)
        {
            FactorA = factorA;
            FactorB = factorB;
            FactorC = factorC;
            SymbolA = symbolA;
            SymbolB = symbolB;
            SymbolC = symbolC;
        }

        public double ObtainYvalue(float x, Eq eq)
        {
            // If symbol is not positive then transfor factor to negative
            if(eq.SymbolA != 1)
            {
                eq.FactorA = -(eq.FactorA);
            }

            if (eq.SymbolB != 1)
            {
                eq.FactorB = -(eq.FactorB);
            }

            if (eq.SymbolC != 1)
            {
                eq.FactorC = -(eq.FactorC);
            }

            // return Ax^2 + Bx + C
            return ((double)eq.FactorA * (Math.Pow(x, 2))) + (eq.FactorB * x) + eq.FactorC;
        }

    }
}
