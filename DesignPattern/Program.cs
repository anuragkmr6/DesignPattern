using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behavioral;
using Creational;
using Structural;
using static System.Console;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational_Design_Pattern
            #region SingleTon
            /*
            var singleton1 = SingleTon.Instance;
            var singleton2 = SingleTon.Instance;

            if (singleton1 == singleton2)
            {
                WriteLine("Both instance are equal");
            }
            */
            #endregion
            #region Builder
            /*
            VehicleBuilder vehicleBuilder;
            vehicleBuilder = new MotorcycleBuilder();
            Builder builder = new Builder();
            builder.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();

            vehicleBuilder = new CarBuilder();
            builder.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();
            */
            #endregion
            #region Factory
            //var factory = new Factory();
            //var obj = factory.GetCalculateFactory("add");
            //obj.Calculate(10, 5);

            //obj = factory.GetCalculateFactory("Divide");
            //obj.Calculate(10, 5);
            #endregion
            #endregion
            #region Structural_Design_Pattern
            #region Facade
            //PersonalLoanFacade facade = new PersonalLoanFacade();
            //Customer customer = new Customer { Id = 101, Name = "Anurag" };
            //var status = facade.IsEligible(customer) == true? "approved" : "rejected";
            //WriteLine($"{customer.Name}'s application is {status}");
            #endregion
            #endregion
            #region Behavioral_Design_Pattern
            #region Observer
            IObserver observer = new Observer("Anurag");
            IObserver observer1 = new Observer("Kumar");
            Subject subject = new Subject();
            subject.Subscribe(observer);
            subject.Subscribe(observer1);
            subject.ItemCount = 1;
            #endregion
            #endregion
            ReadKey();

        }
    }
}
