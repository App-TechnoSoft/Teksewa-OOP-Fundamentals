public class EngineVehicle: Vehicle, IVehicle
{
    public EngineVehicle(string number)
    : base(number)
    {        
    }

    public float EngineCC { get; set; }
    public float Mileage { get; set; }

    public float GetDistanceCovered(float oilUsed) => Mileage * oilUsed;
}
