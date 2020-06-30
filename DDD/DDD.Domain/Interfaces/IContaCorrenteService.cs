using FluentValidation;
using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces
{
    public interface IContaCorrenteService<T>
    {
        string DebitarEmConta<ContaCorrenteValidator>(ContaCorrenteDTO obj) where ContaCorrenteValidator : AbstractValidator<T>;
        string CreditarEmConta<ContaCorrenteValidator>(ContaCorrenteDTO obj) where ContaCorrenteValidator : AbstractValidator<T>;
    }
}