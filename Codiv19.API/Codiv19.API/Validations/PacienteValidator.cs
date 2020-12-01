using Codiv19.API.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Validations
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator()
        {
            RuleFor(p => p.nome).MinimumLength(3).WithMessage("Nome deve conter no mínimo 3 caracteres")
                                 .MaximumLength(100).WithMessage("Nome deve conter no máximo 100 caracteres")
								 .NotEmpty().WithMessage("Nome é obrigatório")
								 .NotNull().WithMessage("Nome é obrigatório");


            RuleFor(p => p.cpf).NotEmpty().WithMessage("Cpf é obrigatório")
                               .NotNull().WithMessage("Cpf é obrigatório")
                               .Must(validaCpf).WithMessage("Cpf é inválido");

			RuleFor(p => p.idade).LessThan(120).WithMessage("Nao e possivel cadastrar um paciente com idade acima de 120 anos")
								 .GreaterThan(0).WithMessage("Nao e possivel cadastrar um paciente com idade negativa");
        }
		
        private bool validaCpf(string cpf)
        {
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}
    }
}
