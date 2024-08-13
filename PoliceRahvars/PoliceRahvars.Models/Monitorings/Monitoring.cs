using PoliceRahvars.Models.Roads;
using PoliceRahvars.Models.Vehicles;

namespace PoliceRahvars.Models.Monitorings;

class Monitoring(
    uint vehicleSpeed, 
    Vehicle vehicle, 
    Road road)
{
    public uint VehicleSpeed { get; } = vehicleSpeed;
    public Vehicle Vehicle { get; } = vehicle;
    public Road Road { get; } = road;
}