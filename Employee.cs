

namespace Lab7
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }
    }
}
