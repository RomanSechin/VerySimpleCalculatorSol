using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySimpleCalculatorProj
{
    internal class SumOperator : Operator
    {
        public SumOperator(MathExpression leftOperand, MathExpression rightOperand) : base(leftOperand, rightOperand)
        {
        }

        public override decimal Calculate()
        {
            return leftOperand.Calculate() + rightOperand.Calculate();
        }
    }
}
