using SoapService.Models;

namespace SoapService.Models
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorResult Add(CalculatorInput input)
        {
            double result = input.Number1 + input.Number2;
            return new CalculatorResult { Result = result };
        }

        public CalculatorResult Subtract(CalculatorInput input)
        {
            double result = input.Number1 - input.Number2;
            return new CalculatorResult { Result = result };
        }

        public CalculatorResult Multiply(CalculatorInput input)
        {
            double result = input.Number1 * input.Number2;
            return new CalculatorResult { Result = result };
        }

        public CalculatorResult Divide(CalculatorInput input)
        {
            if (input.Number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            double result = input.Number1 / input.Number2;
            return new CalculatorResult { Result = result };
        }
    }
}
