using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySimpleCalculatorProj
{
    abstract class Operator : ICalculable
    {
        public MathExpression leftOperand;
        public MathExpression rightOperand;  
        
        public Operator(MathExpression leftOperand, MathExpression rightOperand) 
        { 
            this.leftOperand = leftOperand; 
            this.rightOperand = rightOperand; 
        }

        public abstract decimal Calculate();
    }
}
