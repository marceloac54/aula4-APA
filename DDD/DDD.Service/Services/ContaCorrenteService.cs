using FluentValidation;
using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Infra.Data.Repository;
using System;
using System.Collections.Generic;

namespace DDD.Service.Services
{
    public class ContaCorrenteService<T> : IContaCorrenteService<T>
    {
        private ContaCorrenteRepository<T> repository = new ContaCorrenteRepository<T>();

        public string DebitarEmConta<ContaCorrenteValidator>(ContaCorrenteDTO obj) where ContaCorrenteValidator : AbstractValidator<T>
        {
            obj.ContaCorrente.Debitar(obj.Valor);
            repository.Update(obj.ContaCorrente);
            return "OK";
        }

        public string CreditarEmConta<ContaCorrenteValidator>(ContaCorrenteDTO obj) where ContaCorrenteValidator : AbstractValidator<T>
        {
            obj.ContaCorrente.Creditar(obj.Valor);
            repository.Update(obj.ContaCorrente);
            return "OK";
        }

    }
}