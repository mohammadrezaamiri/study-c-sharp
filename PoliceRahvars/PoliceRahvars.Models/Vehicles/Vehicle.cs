namespace PoliceRahvars.Models.Vehicles;

class Vehicle(string licensePlate, VehicleType type)
{
    public string LicensePlate { get; } = licensePlate;
    public VehicleType Type { get; } = type;
    public decimal TotalFine { get; set; }

    public void IncreaseTotalFine(decimal fine) => TotalFine += fine;
}

public enum VehicleType
{
    Car = 1,
    Truck
}