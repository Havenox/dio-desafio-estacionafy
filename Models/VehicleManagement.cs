using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoCodProprio.Models
{
    public class VehicleManagement
    {
        List<string> Vehicles = new List<string>();

        public bool AddVehicle()
        {
            Console.WriteLine("Estacionafy - Cadastro de Veículo\n\n");
            Console.WriteLine("Insira a Placa do Veículo que está entrando: ");
            string? plate = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Estacionafy - Cadastro de Veículo\n\n");
            if (string.IsNullOrWhiteSpace(plate))
            {
                Console.WriteLine("Erro! Placa inválida...");
                Pause.Wait();
                return false;
            }
            else if (Vehicles.Contains(plate))
            {
                Console.WriteLine("Erro! Veículo já cadastrado...");
                Pause.Wait();
                return false;                
            }
            else
            {
                Vehicles.Add(plate);
                Console.WriteLine($"Novo veículo adicionado! Placa: {Vehicles.Last()}");
                Pause.Wait();
                return true;
            }
        }
        public decimal RemoveVehicles(decimal InicialPrice, decimal HourPrice)
        {
            Console.WriteLine("Estacionafy - Cadastro de Veículo\n\n");
            Console.WriteLine("Insira a Placa do Veículo que está saindo:");
            string? plate = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Estacionafy - Cadastro de Veículo\n\n");

            //verifica se o usuario nao digitou uma placa invalida (nao registrada)
            if (Vehicles.Contains(plate))
            {
                Console.WriteLine("Insira o número de horas estacionadas:");
                string? horas = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Estacionafy - Cadastro de Veículo\n\n");

                //verifica se o usuario digitou um numero ou nao
                if (int.TryParse(horas, out int numHoras))
                {
                    decimal FinalPrice = ParkingCostCalculator.TotalCost(InicialPrice, HourPrice, numHoras);
                    Console.WriteLine("Retirada do veículo Registrada!");
                    Console.WriteLine($"Placa: {plate} - Valor total: R${FinalPrice}");
                    Pause.Wait();
                    Vehicles.Remove(plate);
                    return FinalPrice;
                }
                else
                {
                    Console.WriteLine("Erro! Numero de horas inválido...");
                    Pause.Wait();
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Erro! Placa inválida...");
                Pause.Wait();
                return 0;
            }
        }        
        public void CheckVehicles()
        {
            Console.WriteLine("Estacionafy - Listagem de Veículos\n\n");
            if (Vehicles.Count > 0)
            {
                Console.WriteLine($"Temos {Vehicles.Count} veículo(s) estacionado(s):");
                int count = 1;
                foreach (var vehicle in Vehicles)
                {
                    Console.WriteLine($"{count} - {vehicle}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine($"Não temos nenhum vículo estacionado no momento.");
            }
            Pause.Wait();
        }
        public int CountVehicles()
        {
            return Vehicles.Count;
        }
    }
}