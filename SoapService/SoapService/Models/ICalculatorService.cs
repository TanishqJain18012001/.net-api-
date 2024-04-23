using SoapService.Models;
using System.ServiceModel;

namespace SoapService.Models
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        CalculatorResult Add(CalculatorInput input);

        [OperationContract]
        CalculatorResult Subtract(CalculatorInput input);

        [OperationContract]
        CalculatorResult Multiply(CalculatorInput input);

        [OperationContract]
        CalculatorResult Divide(CalculatorInput input);
    }
}
