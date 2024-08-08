public class ElectricVehicle: Vehicle
{
    public float BatteryCapacity { get; set; }
    public short Range { get; set; }

    public float GetMileage(float distance, float batteryUsedPercentage)
    {
        return 0.0f;
    }
}