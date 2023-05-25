using Trabalho_matemática;

Parking parking = new Parking();

while (true)
{
    Console.WriteLine("-- TRABALHO DE MATEMÁTICA --");
    Console.WriteLine("Digite 0 para encerrar o programa");
    Console.WriteLine("Digite 1 para estacionar um carro");
    Console.WriteLine("Digite 2 para retirar um carro");
    Console.WriteLine("Digite 3 para ver a quantidade de vagas livres");
    Console.WriteLine("Digite 4 para ver a quantidade de carros estacionados");
    Console.WriteLine("Digite 5 para ver a capacidade de máxima de carro");
    Console.WriteLine("Digite 6 para listar carros estacionados");
    Console.WriteLine("Digite 7 para listar carros que saíram");
    Console.WriteLine("Digite 8 para listar todos os carros");

    int cases = Int32.Parse(Console.ReadLine());

    Console.WriteLine();

    if (cases == 0)
        break;

    switch (cases)
    {
        case 1:
            Console.WriteLine("Digite a placa do carro");
            string plateToAdd = Console.ReadLine();
            parking.ParkAdd(new Car(plateToAdd));
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Digite a placa do carro");
            string plateToUpdate = Console.ReadLine();
            parking.ParkUpdate(plateToUpdate);
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine($"Quatidade de vagas livres: {parking.FreeZones}");
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine($"Quatidade de carros estacionados: {parking.ParkedCars}");
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine($"Cacidade máxima de carros: {parking.MaxParkSize}");
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Carros que estão estacionados: ");
            Console.WriteLine(parking.ParkedCarsToString());
            Console.WriteLine();
            break;
        case 7:
            Console.WriteLine("Carros que saíram do estacionamento: ");
            Console.WriteLine(parking.LeavedCarsToString());
            Console.WriteLine();
            break;
        case 8:
            Console.WriteLine("Carros que estacionaram hoje: ");
            Console.WriteLine(parking.AllCarsParked());
            Console.WriteLine();
            break;
    }
}
