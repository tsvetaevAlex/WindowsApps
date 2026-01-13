using System;

namespace Budgethelper.Models
{
    public sealed class User
    {
        /// <summary>
        /// Уникальный идентификатор пользователя
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Имя (обязательное)
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Фамилия (обязательная)
        /// </summary>
        public string Surename { get; }

        /// <summary>
        /// Отчество (необязательное)
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Хэш пароля (SHA256)
        /// </summary>
        public string PasswordHash { get; }

        public DateTime CreatedAt { get; }

        public User(
            string id,
            string firstName,
            string surename,
            string lastName,
            string passwordHash)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            PasswordHash = passwordHash ?? throw new ArgumentNullException(nameof(passwordHash));

            FirstName = string.IsNullOrWhiteSpace(firstName)
                ? throw new ArgumentException("FirstName is required", nameof(firstName))
                : firstName;

            Surename = string.IsNullOrWhiteSpace(surename)
                ? throw new ArgumentException("Surename is required", nameof(surename))
                : surename;

            // отчество может быть null / empty
            LastName = lastName ?? string.Empty;

            CreatedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// Полное имя для UI
        /// </summary>
        public string DisplayName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                    return $"{FirstName} {Surename}";

                return $"{FirstName} {Surename} {LastName}";
            }
        }
    }
}
