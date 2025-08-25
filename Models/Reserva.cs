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
            int numeroHospedes = hospedes.Count();
            int capacidade = Suite.Capacidade;
            if (numeroHospedes <= capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Número de hospedes superior a capacidade permitida!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valor = DiasReservados * valorDiaria;
            if (DiasReservados >= 10)
            {
                valor *= 0.90m;
            }

            return valor;
        }
    }
}