namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private int horas = 0;
        private List<string> veiculos = new List<string>();
        private string placa = "";

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public int CalcularPreco()
        {
            decimal valorTotalDecimal = precoInicial + precoPorHora * horas;
            int valorTotalInt = (int)valorTotalDecimal;
            return valorTotalInt;
        }

        public void AdicionarVeiculo()
        {
            // implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            // implementado
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            // implementado
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                string input;
                decimal valorTotal = 0;

                // implementado
                do
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    input = Console.ReadLine();

                    if (input.ToLower() != "sair" && int.TryParse(input, out horas))
                    {
                        // implementado                
                        valorTotal = CalcularPreco();
                    }
                    else if (input.ToLower() != "sair")
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido.");
                    }

                } while (valorTotal <= 0);              

                // implementado
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        // implementado
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                    // implementado

                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}