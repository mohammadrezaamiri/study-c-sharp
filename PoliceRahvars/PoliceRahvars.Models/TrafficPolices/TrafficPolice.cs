using PoliceRahvars.Models.Monitorings;
using PoliceRahvars.Models.Roads;
using PoliceRahvars.Models.TrafficPolices.Contracts;
using PoliceRahvars.Models.TrafficPolices.Contracts.Dtos;
using PoliceRahvars.Models.Vehicles;

namespace PoliceRahvars.Models.TrafficPolices;

public class TrafficPolice : ITrafficPolice
{
    private readonly List<Monitoring> _monitorings = [];
    private readonly List<Road> _roads = [];
    private readonly List<Vehicle> _vehicles;

    public void RegisterRoad(
        RegisterRoadDto dto)
    {
        var road = new Road(
            dto.StartAddress,
            dto.EndAddress,
            dto.CarSpeedLimit,
            dto.TruckSpeedLimit);
        
        _roads.Add(road);
    }

    public void RegisterVehicle(VehicleType type, string licensePlate)
    {
        if (_vehicles.Any(vehicle => vehicle.LicensePlate == licensePlate))
            return;

        _vehicles.Add(new Vehicle(licensePlate, type));
    }

    public void RegisterMonitoring(uint speed, int vehicleId, int roadId)
    {
        var vehicle = _vehicles[vehicleId - 1];
        var road = _roads[roadId - 1];
        FineVehicleIfHasOverSpeed(speed, vehicle, road);
        var monitoring = new Monitoring(speed, vehicle, road);
        _monitorings.Add(monitoring);
    }

    private static void FineVehicleIfHasOverSpeed(
        uint speed,
        Vehicle vehicle,
        Road road)
    {
        var roadLimit =
            vehicle.Type == VehicleType.Car
                ? road.CarSpeedLimit
                : road.TruckSpeedLimit;
        var overSpeed = speed - roadLimit;

        switch (overSpeed)
        {
            case > 30: vehicle.IncreaseTotalFine(200); break;
            case > 20: vehicle.IncreaseTotalFine(150); break;
            case > 10: vehicle.IncreaseTotalFine(100); break;
        }
    }

    public decimal ShowAllReportViolations(string licensePlate)
            => _vehicles
            .Where(vehicle => vehicle.LicensePlate == licensePlate)
            .Select(vehicle => vehicle.TotalFine)
            .FirstOrDefault();

    public List<ShowVehicleDto> ShowVehicles()
    {
        return _vehicles.Select((vehicle, index) => new ShowVehicleDto
        {
            Id = index + 1,
            LicensePlate = vehicle.LicensePlate,
            Type = vehicle.Type
        }).ToList();
    }

    public List<ShowRoadDto> ShowRoads()
    {
        return _roads.Select((road, index) => new ShowRoadDto
        {
            Id = index + 1,
            StartAddress = road.StartAddress,
            EndAddress = road.EndAddress
            
        }).ToList();
    }

    public List<ShowRoadDto> ShowVehiclesByLimit()
    {
        return _roads
            .Where(road => road.TruckSpeedLimit < 60)
            .Select((road, index) => new ShowRoadDto
            {
                Id = index + 1,
                StartAddress = road.StartAddress,
                EndAddress = road.EndAddress

            }).ToList();
    }
}