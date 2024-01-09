namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();

        
        if (!string.IsNullOrWhiteSpace(placa))
        {
            if (!veiculos.Contains(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Veículo com placa {placa} já está estacionado.");
            }
        }
        else
        {
            Console.WriteLine("Placa inválida. Tente novamente.");
        }
        }

        public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();

        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            
            
            if (int.TryParse(Console.ReadLine(), out int horas) && horas >= 0)
            {
                decimal valorTotal = CalcularValorTotal(horas);
                
                
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Quantidade de horas inválida. Tente novamente.");
            }
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    private decimal CalcularValorTotal(int horas)
    {
        return precoInicial + (precoPorHora * horas);
    }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
