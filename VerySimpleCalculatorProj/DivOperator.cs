using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySimpleCalculatorProj
{
    internal class DivOperator : Operator
    {
        public DivOperator(MathExpression leftOperand, MathExpression rightOperand) : base(leftOperand, rightOperand)
        {
        }

        public override decimal Calculate()
        {
            decimal rightValue = rightOperand.Calculate();
            if (rightValue != 0M)
                return leftOperand.Calculate() / rightValue;
            return 0M;
        }
    }
}
