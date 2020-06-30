using System;
using FluentValidation;
using DDD.Domain.Entities;

namespace DDD.Service.Validators
{
    public class ContaCorrenteValidator : AbstractValidator<ContaCorrenteDTO>
{
	public ContaCorrenteValidator()
        {
	    RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Objeto não encontrado.");
                });
		
            RuleFor(c => c.ContaCorrente)
                .NotNull().WithMessage("Conta inválida.");

            RuleFor(c => c.Valor)
                .NotEmpty().WithMessage("Valor inválido.")
                .NotNull().WithMessage("Valor inválido.");
        }
			}
}