using DDD.Domain.Entities;
using DDD.Domain.Interfaces;
using DDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD.Infra.Data.Repository
{
    public class ContaCorrenteRepository<T> : IContaCorrenteRepository<T>
    {
        private SQLiteContext context = new SQLiteContext();

        public void Update(ContaCorrente obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}