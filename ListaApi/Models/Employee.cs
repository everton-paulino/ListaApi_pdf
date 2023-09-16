namespace ListaApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string CompleteName { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
    }
}
