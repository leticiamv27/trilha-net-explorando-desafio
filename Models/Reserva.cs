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
            
            if (hospedes.Count <= 2)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("A quantidade de hóspedes excede o permitido nesta unidade. Por favor, escolha outra suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            int hospedes = Hospedes.Count; 
            return hospedes;
            
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = DiasReservados * Suite.ValorDiaria * 90/100;
;
            }

            return valor;
        }
    }
}