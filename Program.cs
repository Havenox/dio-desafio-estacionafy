using EstacionamentoCodProprio.Models;

Console.Clear();


//instancing the needed classes
PriceManagement prices = new PriceManagement();
VehicleManagement vehicles = new VehicleManagement();


//motd - show a start message to the user
Console.WriteLine("Seja bem vindo ao Estacionafy!\n\n");
Console.WriteLine("Para iniciar o sistema, você precisa informar os preços do estacionamento.");
Pause.Wait(); //a utility method to ask for input, wait for it, and clear the display... to avoid too much rewrite same code



//call SetPrices to change the parking prices
prices.SetPrices();

//start the main menu of the application
string? option = "-1";
//
int vehicleEntryCount = 0, vehicleExitCount = 0;
decimal totalRevenue = 0;
do
{
    Console.WriteLine("Estacionafy - Menu Principal\n\n");
    Console.WriteLine("Digite a opção desejada:\n");
    Console.WriteLine("1 - Cadastrar ENTRADA de veículo");
    Console.WriteLine("2 - Cadastrar SAÍDA veículo");
    Console.WriteLine("3 - Listar veículos estacionados");
    Console.WriteLine("4 - Verificar os Preços do Estacionamento");
    Console.WriteLine("5 - Alterar os Preços do Estacionamento");
    Console.WriteLine("6 - Verificar Rendimento até o Momento");
    Console.WriteLine("0 - Encerrar Aplicação");
    option = Convert.ToString(Console.ReadLine());
    Console.Clear();

    switch (option)
    {
        //case 1 - register vehicle entry... if succed, add up to vehice entry counter
        case "1":
            if (vehicles.AddVehicle()) vehicleEntryCount++;
            break;
        
        // case 2 - register vehicle exit... if succed, add up to vehicle exit counter
        case "2":
            decimal revenue = vehicles.RemoveVehicles(prices.InitialPrice, prices.HourPrice);
            if (revenue > 0)
            {
                totalRevenue += revenue;
                vehicleExitCount++;
            }
            break;
        // case 3 - just check the List of Vehicles
        case "3":
            vehicles.CheckVehicles();
            break;
        // case 4 - just check the prices registered
        case "4":
            prices.CheckPrices();
            break;
        // case 5 - change the prices
        case "5":
            prices.SetPrices();
            break;
        // case 6 - check the revenue until now
        case "6":
            Console.WriteLine("Estacionafy - Rendimento\n\n");
            if (totalRevenue > 0)
            {
                Console.WriteLine($"Rendimento total registrado no período: R${totalRevenue}\n");
            }
            else
            {
                Console.WriteLine("Nenhum Rendimento registrado até o momento.");
            }
            Pause.Wait();
            break;
        //default do nothing
        default:
            break;

    }

} while (option != "0");


Console.WriteLine("Encerrando expediente no Estacionafy...\n");
if(vehicleEntryCount>0) Console.WriteLine($"Registros de entrada no período: {vehicleEntryCount}");
if(vehicleExitCount>0) Console.WriteLine($"Registros de saída no período: {vehicleExitCount}");
if(vehicles.CountVehicles()>0) Console.WriteLine($"Veículos ainda Estacionados: {vehicles.CountVehicles()}");
if(totalRevenue>0) Console.WriteLine($"Rendimento total registrado no período: R${totalRevenue}\n");
Console.WriteLine("Obrigado por utilizar o Estacionafy! Até a próxima o/");
Pause.Wait();