using System;
using FluentValidation;
using FluentValidation.Results;

namespace Eventos.IO.Domain.Core.Entities
{
    public abstract class Entity<T> : AbstractValidator<T> where T : Entity<T>
    {
        public Guid Id { get; protected set; }
        public ValidationResult ValidationResult { get; protected set; }

        public abstract bool EhValido();

        public Entity()
        {
            ValidationResult = new ValidationResult();
        }
    }
}