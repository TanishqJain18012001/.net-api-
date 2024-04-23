using System.Runtime.Serialization;

namespace SoapService.Models
{
    public class CalculatorInput
    {
        [DataMember]
        public double Number1 { get; set; }

        [DataMember]
        public double Number2 { get; set; }
    }

    [DataContract]
    public class CalculatorResult
    {
        [DataMember]
        public double Result { get; set; }
    }
}
