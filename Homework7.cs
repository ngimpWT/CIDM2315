namespace Homework7;
class Program
{
    static void Main(string[] args)
    	{
            // Answer Q1 and Q2

            //Instantiates customer1 and customer2, along with values
            Customer customer1 = new Customer(110, "Alice", 28);
            Customer customer2 = new Customer(111, "Bob", 30);
            //Prints info
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();
            //Changes customer1 and customer2 ID
            customer1.ChangeID(220);
            customer2.ChangeID(221);
            //Prints info with updated ID
            customer1.PrintCusInfo();
            customer2.PrintCusInfo();
            //Compares customer1 age to customer2
            customer1.CompareAge(customer2);
        }
}
class Customer 
{
// Code for Customer class
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int id, string name, int age) //constructor used to assign id, name and age to the customer when an object is created.
        {
        cus_id = id;
        cus_name = name;
        cus_age = age;
        }
    public void ChangeID(int new_id) // method used to change customer id
    {
        cus_id = new_id;
    }
    public void PrintCusInfo() // method used to print customer information(id, name, age)
    {
        Console.WriteLine($"Customer: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }
    public void CompareAge(Customer objAge) // method used to compare the current object’s age with the objCustomer’s age. Then print out the cus_name of the older customer.
    {
        if(this.cus_age >= objAge.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objAge.cus_name} is older");
        }
    }
}