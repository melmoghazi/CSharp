using AbstractClass_EmployeeExample.AbstractBaseClass;

namespace AbstractClass_EmployeeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("two classes example, full time employee");
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Mohammed";
            fte.LastName = "Ali";
            fte.AnnualSalary = 60000;
            Console.WriteLine($"Full Name: {fte.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {fte.GetMonthlySalary()}");

            Console.WriteLine("two classes example, contract employee");
            ContractEmployee cte = new ContractEmployee();
            cte.FirstName = "Sara";
            cte.LastName = "Omar";
            cte.TotalHoursWorked = 160;
            cte.HourlyPay = 5;
            Console.WriteLine($"Full Name: {cte.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {cte.GetMonthlySalary()}");

            Console.WriteLine(@"the two classes ary related, what if you need to add new properity middle name then 
you will add a new properity middle name then add in the GetFullName method but you need to add that in the both classes...");

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ConcreteBaseClass example, full time employee");
            AbstractClass_EmployeeExample.ConcreteBaseClass.FullTimeEmployee full = new AbstractClass_EmployeeExample.ConcreteBaseClass.FullTimeEmployee();
            full.FirstName = "Mohammed";
            full.LastName = "Ali";
            full.AnnualSalary = 60000;
            Console.WriteLine($"Full Name: {fte.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {fte.GetMonthlySalary()}");

            Console.WriteLine("ConcreteBaseClass example, contract employee");
            AbstractClass_EmployeeExample.ConcreteBaseClass.ContractEmployee contract = new AbstractClass_EmployeeExample.ConcreteBaseClass.ContractEmployee();
            cte.FirstName = "Sara";
            cte.LastName = "Omar";
            cte.TotalHoursWorked = 160;
            cte.HourlyPay = 5;
            Console.WriteLine($"Full Name: {cte.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {cte.GetMonthlySalary()}");
            Console.WriteLine(@"this is a good solution but we can can create an object from BaseEmployee class and if we called the GetMonthlySalary
method this will throw NotImplementedException");

            AbstractClass_EmployeeExample.ConcreteBaseClass.BaseEmployee baseEmp = new AbstractClass_EmployeeExample.ConcreteBaseClass.BaseEmployee();
            baseEmp.FirstName = "Hind";
            baseEmp.LastName = "Ali";
            Console.WriteLine($"Full Name: {baseEmp.GetFullName()}");
            //Console.WriteLine($"Monthly Salary: {baseEmp.GetMonthlySalary()}");

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("We can not create an object from Abstract class");
            //AbstractClass_EmployeeExample.AbstractBaseClass.BaseEmployee abstractBaseEmp = new 

            Console.WriteLine("AbstractBaseClass example, full time employee");
            AbstractClass_EmployeeExample.AbstractBaseClass.FullTimeEmployee AbstractFull = new AbstractClass_EmployeeExample.AbstractBaseClass.FullTimeEmployee();
            AbstractFull.FirstName = "Mohammed";
            AbstractFull.LastName = "Ali";
            AbstractFull.AnnualSalary = 60000;
            Console.WriteLine($"Full Name: {AbstractFull.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {AbstractFull.GetMonthlySalary()}");

            Console.WriteLine("AbstractBaseClass example, contract employee");
            AbstractClass_EmployeeExample.AbstractBaseClass.ContractEmployee AbstractContract = new AbstractClass_EmployeeExample.AbstractBaseClass.ContractEmployee();
            AbstractContract.FirstName = "Sara";
            AbstractContract.LastName = "Omar";
            AbstractContract.TotalHoursWorked = 160;
            AbstractContract.HourlyPay = 5;
            Console.WriteLine($"Full Name: {AbstractContract.GetFullName()}");
            Console.WriteLine($"Monthly Salary: {AbstractContract.GetMonthlySalary()}");

            Console.WriteLine(@"So we would create an abstract class when want to move the common functionality of 2 or more classes 
into a base class and when we don't want that base class to be instantiated.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("call method from abstract class constructor example");
            AbstractClass_EmployeeExample.AbstractClassConstructor.FullTimeEmployee fEmployee = new AbstractClass_EmployeeExample.AbstractClassConstructor.FullTimeEmployee();
            AbstractClass_EmployeeExample.AbstractClassConstructor.ContractEmployee cEmployee = new AbstractClass_EmployeeExample.AbstractClassConstructor.ContractEmployee();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("call virtual method from abstract classexample");
            AbstractClass_EmployeeExample.AbstractClassVirtualMethod.FullTimeEmployee virtualFullTimeEmployee = new AbstractClass_EmployeeExample.AbstractClassVirtualMethod.FullTimeEmployee();
            virtualFullTimeEmployee.VirtualMehtod();
            AbstractClass_EmployeeExample.AbstractClassVirtualMethod.ContractEmployee virtualContractEmployee = new AbstractClass_EmployeeExample.AbstractClassVirtualMethod.ContractEmployee();
            virtualContractEmployee.VirtualMehtod();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("call virtual method from concrete class example");



            AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.FullTimeEmployee ccfullTimeEmployee = new AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.FullTimeEmployee();
            ccfullTimeEmployee.VirtualMehtod();
            AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.ContractEmployee cccontractEmployee = new AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.ContractEmployee();
            cccontractEmployee.VirtualMehtod();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("call virtual method with new vs override from concrete class example");

            AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.Employee ccEmployee =
                new AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.ContractEmployee();
            ccEmployee.VirtualMehtod();  //calls base
            AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.ContractEmployee cc2Employee =
                new AbstractClass_EmployeeExample.ConcreteClassVirtualMethod.ContractEmployee();
            cc2Employee.VirtualMehtod(); // calls derived


            Console.ReadLine();
        }
    }
}
