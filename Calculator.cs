namespace SharpCalculator
{
    public class Calculator
    {
        private double _firstNumber = 0;
        private string? _currentOperation = null;
        private bool _isNewEntry = true;

        // Gestisce la digitazione dei numeri
        public string PressNumber(string currentDisplayText, string numberPressed)
        {
            if (_isNewEntry || currentDisplayText == "0")
            {
                _isNewEntry = false;
                return numberPressed;
            }

            return currentDisplayText + numberPressed;
        }

        // Gestisce la digitazione degli operatori (+, -, *, /)
        public string PressOperator(string currentDisplayText, string newOperation)
        {
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

        // Gestisce la pressione del tasto '='
        public string PressEquals(string currentDisplayText)
        {
            if (_currentOperation == null) 
                return currentDisplayText;

            double secondNumber = double.Parse(currentDisplayText);
            double result = ExecuteCalculation(_firstNumber, secondNumber, _currentOperation);

            _currentOperation = null; // Operazione conclusa
            _isNewEntry = true;

            return result.ToString("0.#####");
        }

        // Resetta la calcolatrice (Tasto C / Clear)
        public string Clear()
        {
            _firstNumber = 0;
            _currentOperation = null;
            _isNewEntry = true;
            return "0";
        }

        // Metodo privato di supporto per la matematica
        private double ExecuteCalculation(double val1, double val2, string operation)
        {
            return operation switch
            {
                "+" => val1 + val2,
                "-" => val1 - val2,
                "*" => val1 * val2,
                "/" => val2 != 0 ? val1 / val2 : 0, // Evita la divisione per zero
                _ => val2
            };
        }
    }
}