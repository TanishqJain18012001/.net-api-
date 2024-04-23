using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapService.Models;
namespace SoapService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        public MyCalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpPost("add")]
        public ActionResult<double> Add(double num1, double num2)
        {
            try
            {
                var request = new CalculatorInput { Number1 = num1, Number2 = num2 };
                var response = _calculatorService.Add(request);
                return Ok(response.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Subtract")]
        public ActionResult<double> Subtract(double num1, double num2)
        {
            try
            {
                var request = new CalculatorInput { Number1 = num1, Number2 = num2 };
                var response = _calculatorService.Subtract(request);
                return Ok(response.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        [HttpPost("Multiply")]
        public ActionResult<double> Multiply(double num1, double num2)
        {
            try
            {
                var request = new CalculatorInput { Number1 = num1, Number2 = num2 };
                var response = _calculatorService.Multiply(request);
                return Ok(response.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("divide")]
        public ActionResult<double> Divide(double num1, double num2)
        {
            try
            {
                var request = new CalculatorInput { Number1 = num1, Number2 = num2 };
                var response = _calculatorService.Divide(request);
                return Ok(response.Result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}







