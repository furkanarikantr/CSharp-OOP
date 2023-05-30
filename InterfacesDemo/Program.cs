namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            EmployeeManager employeeManager = new EmployeeManager();

            Person customer1 = new Customer();
            customer1.FirstName = "Furkan";
            Person employee1 = new Employee();
            employee1.FirstName = "Duygu";

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager, customer1);
            projectManager.Add(employeeManager, employee1);
        }
    }
}