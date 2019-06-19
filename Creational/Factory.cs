using System;
using System.Collections.Generic;
using System.Text;

namespace Creational
{
    /// <summary>
    /// Used to define a runtime interface for creating an object.
    /// </summary>
    public class Factory
    {
        public ICalculate GetCalculateFactory(string operation)
        {
            ICalculate obj = null;
            if(operation.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if(operation.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            return obj;
        }
    }

    public interface ICalculate
    {
        void Calculate(double firstNum, double secondNum);
    }

    public class Add : ICalculate
    {
        public void Calculate(double firstNum, double secondNum)
        {
            Console.WriteLine($" {firstNum} + {secondNum} = {firstNum + secondNum}");
        }
    }

    public class Divide : ICalculate
    {
        public void Calculate(double firstNum, double secondNum)
        {
            Console.WriteLine($" {firstNum} / {secondNum} = {firstNum / secondNum}");
        }
    }

}
