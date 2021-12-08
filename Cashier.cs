

namespace Lab7
{
    class Cashier : Employee
    {
        public string Qualification { get; set; }

        public new string GetFullName()
        {
            return $"{FirstName} {LastName} – квалификация: {Qualification}";
        }
    }
}
