using DDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DDD.Domain.Interfaces
{
    public interface IContaCorrenteRepository<T> {
        void Update(ContaCorrente obj);
    }
}