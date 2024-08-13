namespace PoliceRahvars.Models.Roads;

class Road(
    string startAddress, 
    string endAddress, 
    uint carSpeedLimit, 
    uint truckSpeedLimit)
{
    public string StartAddress { get; } = startAddress;
    public string EndAddress { get; } = endAddress;
    public uint CarSpeedLimit { get; } = carSpeedLimit;
    public uint TruckSpeedLimit { get; } = truckSpeedLimit;
}