using System;

namespace DDD.Domain.Entities
{
    public class Correntista : BaseEntity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
    }
}