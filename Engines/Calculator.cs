namespace SharpCalculator.Engines
{
    public class Calculator
    {
        private double _firstNumber = 0;
        private string? _currentOperation = null;
        private bool _isNewEntry = true;
        private bool _isNewMinusSign = true;

        // Gestisce la digitazione dei numeri
        public string PressNumber(string currentDisplayText, string numberPressed)
        {
            if (currentDisplayText == "-")
            {
                _isNewEntry = false;
                return "-" + numberPressed;
            }

            if (_isNewEntry || currentDisplayText == "0")
            {
                _isNewEntry = false;
                return numberPressed;
            }
            
            _isNewMinusSign =  false;
            
            return currentDisplayText + numberPressed;
        }

        // Gestisce la digitazione degli operatori (+, -, *, /)
        public string PressOperator(string currentDisplayText, string newOperation)
        {
            if (newOperation == "-" && (_isNewMinusSign || currentDisplayText == "0"))
            {
                _isNewMinusSign = false;
                return "-";
            }

            if (currentDisplayText == "-")
            {
                return currentDisplayText;
            }

            double currentDisplayValue = double.Parse(currentDisplayText);

            // Se c'era già un'operazione in sospeso, esegui il calcolo intermedio
            if (_currentOperation != null && !_isNewEntry)
            {
                currentDisplayValue = ExecuteCalculation(_firstNumber, currentDisplayValue, _currentOperation);
            }

            _firstNumber = currentDisplayValue;
            _currentOperation = newOperation;
            _isNewEntry = true; // Il prossimo numero pulirà il display

            return currentDisplayValue.ToString("0.#####");
        }
        
        public string PressEquals(string currentDisplayText)
        {
            if (_currentOperation == null || currentDisplayText == "-") 
                return currentDisplayText;

            double secondNumber = double.Parse(currentDisplayText);
            double result = ExecuteCalculation(_firstNumber, secondNumber, _currentOperation);

            _currentOperation = null; // Operazione conclusa
            _isNewEntry = true;

            return result.ToString("0.#####");
        }

        // Calculator reset
        public string Clear()
        {
            _firstNumber = 0;
            _currentOperation = null;
            _isNewEntry = true;
            _isNewMinusSign = true;
            return "0";
        }
        
        private double ExecuteCalculation(double val1, double val2, string operation)
        {
            return operation switch
            {
                "+" => val1 + val2,
                "-" => val1 - val2,
                "*" => val1 * val2,
                "/" => val2 != 0 ? val1 / val2 : 0, // If the user tries to divide by 0 it returns 0
                _ => val2
            };
        }
    }
}