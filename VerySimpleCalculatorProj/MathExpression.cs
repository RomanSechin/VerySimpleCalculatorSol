using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Text.RegularExpressions.Regex;

namespace VerySimpleCalculatorProj
{
    class MathExpression : ICalculable
    {
        private string _mathExpression;
        private decimal? _value;
        private string[] _mathOperators = new[]{ "+", "-", "*", "/" };
        private Regex _regexCBraces  = new Regex(@"\([^()]*\)");
        //private Regex _regexOperands = new Regex(@"(\+|\-|\*|\/)");
        private int _operatorPosition;
        private string _operatorName = "";
        private MathExpression? _leftOperand;
        private MathExpression? _rightOperand;
        public MathExpression(string mathExpression)
        {
            _mathExpression = mathExpression.Replace(" ", "");
            Decimal.TryParse(_mathExpression, out decimal _value);
        }

        public decimal Calculate()
        {
            if (_value != null)
                return (decimal)_value;
            while (_regexCBraces.IsMatch(_mathExpression))
            {
                string matchedExp = "";
                //_mathExpression = _mathExpression.Substring(1, _mathExpression.Length - 2);
                var listOfBraces = _regexCBraces.Matches(_mathExpression);
                foreach (var brace in listOfBraces) {
                    _mathExpression.Replace(brace.ToString(), (new MathExpression(brace.ToString())).Calculate().ToString());
                }
                if (result < 0M) { 
                    _mathExpression.Replace()
                }
            }   
                foreach (var op in _mathOperators) {
                    if (_mathExpression.Contains(op)) { 
                        _operatorPosition = _mathExpression.IndexOf(op);
                        _operatorName = op.ToString();
                        break;
                    }
                }
                Operator _currentOperator;
                _leftOperand = new MathExpression(_mathExpression.Substring(0,_operatorPosition));
                _rightOperand = new MathExpression(_mathExpression.Substring(_operatorPosition + 1));
                
                switch (_operatorName) { 
                    case "+": _currentOperator = new SumOperator(_leftOperand, _rightOperand); break;
                    case "-": _currentOperator = new SubOperator(_leftOperand, _rightOperand); break;
                    case "*": _currentOperator = new MulOperator(_leftOperand, _rightOperand); break;
                    case "/": _currentOperator = new DivOperator(_leftOperand, _rightOperand); break;
                    default: _currentOperator = null; break;
                }
                if (_currentOperator != null) {
                    return _currentOperator.Calculate();
                }
            return 0M;   
        }
    }
}
