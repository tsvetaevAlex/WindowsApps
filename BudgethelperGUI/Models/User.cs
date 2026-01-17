using System;

namespace Budgethelper.Models
{
    public sealed class User
    {
        public string Id { get; }
        public string FirstName { get; }
        public string Surname { get; }
        public string LastName { get; } // optional (отчество)

        public User(string id, string firstName, string surname, string lastName = "")
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            FirstName = string.IsNullOrWhiteSpace(firstName)
                ? throw new ArgumentException("FirstName is required")
                : firstName;

            Surname = string.IsNullOrWhiteSpace(surname)
                ? throw new ArgumentException("Surname is required")
                : surname;

            LastName = lastName ?? string.Empty;
        }

        public override string ToString()
        {
            return string.IsNullOrWhiteSpace(LastName)
                ? $"{FirstName} {Surname}"
                : $"{FirstName} {Surname} {LastName}";
        }
    }
}
