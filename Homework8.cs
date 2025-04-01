namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);
        Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        // call Q1 method
        TotalCredits(customer_list);

        // call Q2 method
        AmarilloAverageAge(customer_list);

        // call Q3 method
        CanyonAge(customer_list);
    }
// Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;
        foreach(Customer credit in customer_list)
        {
            totalCredit += credit.customerCredit;
        }
        Console.WriteLine($"The total credit of all customers is: {totalCredit}");
    }
// Q2 Create a method to calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        double totalAge = 0;
        int countAge = 0;
         foreach(var k in customer_list)
        {
            if(k.customerCity == "Amarillo")
            {
            totalAge += k.customerAge;
            countAge++;
            }
        }
        if (countAge > 0)
        {
            double averageAge = totalAge/countAge;
            Console.WriteLine($"Q2: The average age of customers in Amarillo is: {averageAge}");
        }
    }
// Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.Write($"Q3: Customers who live in Canyon and over 30 years old: ");
        foreach(var k in customer_list)
        {
            if(k.customerAge > 30)
                if(k.customerCity == "Canyon")
                    Console.Write($"{k.customerName},");
        }
        Console.WriteLine(""); //Starts new line at the end of code
    }
}

// Q0: Create a class called Customer
class Customer
{
    public string customerName;
    public int customerAge;
    public string customerCity;
    public double customerCredit;

    // constructor
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}