namespace Adapter.Models
{
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { " Pesho", "Peshov", "Team Leader" };
            employees[1] = new string[] { "Gosho", "Goshov", "Developer" };
            employees[2] = new string[] { "Stamat", "Stamatov", "Developer" };
            employees[3] = new string[] { "Bobi", "Bobev", "Tester" };

            return employees;
        }
    }
}
