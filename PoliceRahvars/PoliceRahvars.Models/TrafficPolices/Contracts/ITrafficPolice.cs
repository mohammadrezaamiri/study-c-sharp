using PoliceRahvars.Models.TrafficPolices.Contracts.Dtos;
using PoliceRahvars.Models.Vehicles;

namespace PoliceRahvars.Models.TrafficPolices.Contracts;

public interface ITrafficPolice
{
    void RegisterRoad(RegisterRoadDto dto);
    void RegisterVehicle(VehicleType type, string licensePlate);
    void RegisterMonitoring(uint speed, int vehicleId, int roadId);
    decimal ShowAllReportViolations(string licensePlate);
    List<ShowVehicleDto> ShowVehicles();
    List<ShowRoadDto> ShowRoads();
    List<ShowRoadDto> ShowVehiclesByLimit();
}