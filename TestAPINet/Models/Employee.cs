namespace TestAPINet.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string JobPosition { get; set; }
        public decimal Wage { get; set; } 
        public string Status { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Beneficiary Beneficiary { get; set; }
    }

    public class Beneficiary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        
        public string Name { get; set; }
        public string RelationShip { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public bool IsDeleted { get; set; }
    }
}
