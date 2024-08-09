public class ElectricVehicle : Vehicle, IVehicle
{
    public ElectricVehicle(string number, short range, float battercapacity)
    : base(number)
    {           
        Range = range;
        BatteryCapacity = battercapacity;     
    }

    public float BatteryCapacity { get; set; }
    public short Range { get; set; }

    public float GetDistanceCovered(float batteryUsedPercentage) => Range / 100 * batteryUsedPercentage;
}
