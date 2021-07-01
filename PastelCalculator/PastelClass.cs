using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelCalculator
{
    class PastelClass
    {
        private String operation = "";
        private  Double value = 0;
        private String value2;

        public string Operation { get => operation; set => operation = value; }
        public double Value { get => value; set => this.value = value; }
        public string Value2 { get => value2; set => value2 = value; }

        public void Operators()
        {
            switch (operation)
            {
                case "+":
                    Value2 = Convert.ToString(value + Double.Parse(Value2));
                    break;
                case "-":
                    Value2 = Convert.ToString(value - Double.Parse(Value2));
                    break;
                case "*":
                    Value2 = Convert.ToString(value * Double.Parse(Value2));
                    break;
                case "/":
                    Value2 = Convert.ToString(value / Double.Parse(Value2));
                    break;
                default:
                    break;
            }
        }
    }
}
