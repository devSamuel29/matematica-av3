using System.Text.RegularExpressions;

namespace Trabalho_matemática;

public class Car
{
    private string _plate;
    public string Plate
    {
        get { return _plate; }
    }

    public string LocalPlate
    {
        get { return States.getState(_plate); }
    }

    public DateTime? ArrivedAt { get; set; }

    public DateTime? DepartedAt { get; set; }

    public decimal ToPay
    {
        get { return Parking.CalculateBill(ArrivedAt, DepartedAt); }
        set { ToPay = value; }
    }

    public Car(String plate)
    {
        _plate = plate;
        ArrivedAt = null;
        DepartedAt = null;
    }

    public override string ToString()
    {
        return $"Carro: Placa = {_plate}, Local da placa = {LocalPlate}, Chegou às = {(ArrivedAt == null ? "ainda não estacionou" : ArrivedAt)}, Saiu às = {(DepartedAt == null ? "ainda não saiu" : DepartedAt)}, Conta = {(DepartedAt == null ? "nada a pagar por enquanto" : $"R$ {ToPay}")}.";
    }
}
