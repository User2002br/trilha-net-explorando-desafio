using System.Collections.Generic;
using System.Globalization;
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // FEITO
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // FEITO
                throw new ArgumentException("A quantidade des hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // FEITO
            int QuantidadeHospedes = Hospedes.Count;
            return  QuantidadeHospedes;
;
        }

        public string CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // FEITO
            decimal valor =  DiasReservados * Suite.ValorDiaria;
            string valorFormatado = " ";
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // FEITO
            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 0.10m;
                valor = valor - desconto;
                valorFormatado = valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
                valorFormatado = valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            return valorFormatado;
        }
    }
}