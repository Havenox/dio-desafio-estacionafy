using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoCodProprio.Models
{
    public class PriceManagement
    {
        public decimal InitialPrice { get; set; }
        public decimal HourPrice { get; set; }

        public void SetPrices()
        {
            Console.WriteLine("Estacionafy - Configuração de Preços\n\n");
            Console.WriteLine("1 - Preço de entrada no Estacionamento:");
            InitialPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Estacionafy - Configuração de Preços\n");
            Console.WriteLine("Preço de entrada armazenado!\n");
            Console.WriteLine("2 - Preço por hora estacionado:");
            HourPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Estacionafy - Configuração de Preços\n");
            Console.WriteLine("Preço por hora armazenado!\n");
            Pause.Wait();
            //when prices are setted, the very same function calls the check prices to show the changes
            CheckPrices();
        }
        public void CheckPrices()
        {
            Console.WriteLine("Estacionafy - Verificando Preços\n\n");
            Console.WriteLine("O preços do estacionamento são os seguintes:");
            Console.WriteLine($"Preço de entrada no estacionamento: R${InitialPrice}");
            Console.WriteLine($"Preço por hora estacionado: R${HourPrice}");
            Pause.Wait();
        }
    }
}