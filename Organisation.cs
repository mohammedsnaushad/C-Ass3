using System;

public class Employee
{
	public string Employee_Name;
	public int Employee_ID;
	public double Salary;
	public double GrossSalary;
	public double NetSalary;
	public double Allowance;
	public virtual void getValues()
	{
		Console.WriteLine("Enter the employee Id");
		
		Employee_ID = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the employee name");
		Employee_Name = Convert.ToString(Console.ReadLine());
		Console.WriteLine("Enter the salary");
		Salary = Convert.ToDouble(Console.ReadLine());
	}
	public virtual double CalculateSalary()
	{
		GrossSalary = Salary + Allowance;
		return GrossSalary;
	}
	public virtual double Calculate()
	{
		double PF;
		PF = 12 * GrossSalary;
		NetSalary = GrossSalary - PF;
		return NetSalary;
	}

	public void display()
	{
		Console.WriteLine("Employee Id : {0}", Employee_ID);
		Console.WriteLine("Employee Name : {0}", Employee_Name);
		Console.WriteLine("Employee Salary : {0}", Salary);
		Console.WriteLine("Employee Gross : {0}", GrossSalary);
		Console.WriteLine("Employee Net : {0}", NetSalary);
	}
}
class Manager : Employee
{
	public override void getValues()
	{
		base.getValues();
	}
	public override double CalculateSalary()
	{
		
		Allowance =8 + 13 + 3;
		GrossSalary = Salary + Allowance;
		return GrossSalary;
	}

	public override double Calculate()
	{
		double PF;
		PF = 12 * GrossSalary;
		NetSalary = PF-GrossSalary;
		return NetSalary;
	}
}
class MarketingExecutive : Employee
{
	public override void getValues()
	{
		base.getValues();
	}
	public override double CalculateSalary()
	{
		Console.WriteLine("Enter the Km travelled");
		double km = Convert.ToDouble(Console.ReadLine());
		Allowance = ((km * 5) + 1000);
		GrossSalary = Salary + Allowance;
		return GrossSalary;
	}
	public override double Calculate()
	{
		double PF = 12 * GrossSalary;
		NetSalary = PF-GrossSalary;
		return NetSalary;
	}
}
public class Program
{
	public static void Main()
	{
		Manager mngr = new Manager();
		Employee mex = new MarketingExecutive();
		Console.WriteLine("Enter the details of manager:");
		mngr.getValues();
		Console.WriteLine("Enter the details of executive:");
		mex.getValues();
		mngr.CalculateSalary();
		mngr.Calculate();
		mex.CalculateSalary();
		mex.Calculate();
		mngr.display();
		mex.display();
	}
}