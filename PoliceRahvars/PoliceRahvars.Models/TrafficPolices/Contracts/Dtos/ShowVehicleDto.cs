using PoliceRahvars.Models.Vehicles;

namespace PoliceRahvars.Models.TrafficPolices.Contracts.Dtos;

public class ShowVehicleDto
{
    public int Id { get; set; }
    public VehicleType Type { get; set; }
    public string LicensePlate { get; set; }
}