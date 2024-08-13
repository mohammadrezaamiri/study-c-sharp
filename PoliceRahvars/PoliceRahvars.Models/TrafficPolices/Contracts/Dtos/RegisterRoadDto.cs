namespace PoliceRahvars.Models.TrafficPolices.Contracts.Dtos;

public class RegisterRoadDto
{
    public string StartAddress { get; set; }
    public string EndAddress { get; set; }
    public uint CarSpeedLimit { get; set; }
    public uint TruckSpeedLimit { get; set; }
}