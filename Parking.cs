#nullable disable

using System.Text;

namespace Trabalho_matemática;

public class Parking
{
    private const int MAX_PARK_SIZE = 20;
    public int MaxParkSize
    {
        get { return MAX_PARK_SIZE; }
    }

    private int _parkedCars;
    public int ParkedCars
    {
        get { return _parkedCars; }
    }
    public int FreeZones
    {
        get { return MAX_PARK_SIZE - _parkedCars; }
    }

    private List<Car> _parkingList;
    public List<Car> ParkingList
    {
        get { return _parkingList; }
    }

    private List<Car> _carsLeaved;
    public List<Car> CarsLeaved
    {
        get { return _carsLeaved; }
    }

    private List<Car> _allCars;
    public List<Car> AllCars
    {
        get { return _allCars; }
    }

    public Parking()
    {
        _parkedCars = 0;
        _parkingList = new List<Car>();
        _carsLeaved = new List<Car>();
        _allCars = new List<Car>();
    }

    public int CarsParked()
    {
        return _parkingList.Count;
    }

    public void ParkAdd(Car car)
    {
        if (_parkedCars < MAX_PARK_SIZE)
        {
            car.ArrivedAt = DateTime.Now;
            _parkedCars++;
            _allCars.Add(car);
            _parkingList.Add(car);
        }
    }

    public void ParkUpdate(string plate)
    {
        ParkUpdate(_parkingList.Where(u => u.Plate == plate).FirstOrDefault());
        ParkRemove(_parkingList.Where(u => u.Plate == plate).FirstOrDefault());
    }

    public void ParkUpdate(Car car)
    {
        car.DepartedAt = DateTime.Now;
    }

    public void ParkRemove(Car car)
    {
        _parkedCars--;
        _carsLeaved.Add(car);
        _parkingList.Remove(car);
    }

    public string ParkedCarsToString()
    {
        StringBuilder sb = new StringBuilder();

        _parkingList.ForEach(u =>
        {
            sb.AppendLine(u.ToString());
        });

        return sb.ToString();
    }

    public string LeavedCarsToString()
    {
        StringBuilder sb = new StringBuilder();

        _carsLeaved.ForEach(u =>
        {
            sb.AppendLine(u.ToString());
        });

        return sb.ToString();
    }

    public string GetLastCar(string plate) 
    { 
        return _carsLeaved.Where(u => u.Plate == plate).LastOrDefault().ToString();
    }

    public string AllCarsParked()
    {
        StringBuilder sb = new StringBuilder();

        _allCars.ForEach(u =>
        {
            sb.AppendLine(u.ToString());
        });

        return sb.ToString();
    }

    public static decimal CalculateBill(DateTime? arrivedAt, DateTime? departedAt)
    {
        TimeSpan duration = departedAt.Value - arrivedAt.Value;
        double totalHours = Math.Ceiling(duration.TotalHours);

        if (duration.TotalMinutes <= 15)
        {
            totalHours = 0;
        }

        decimal additionalRate = 5.25m;
        decimal totalBill = additionalRate * (decimal)totalHours;
        return totalBill;
    }
}
