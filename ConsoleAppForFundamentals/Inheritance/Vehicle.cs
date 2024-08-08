public class Vehicle
{
    string vehicleNumber;

    public string VehicleNumber 
    {
        get => vehicleNumber;
        set
        {
            if(value != "" && value.Length > 5)
                vehicleNumber = value;
        }
    }

    public string Brand { get; set; } = "";
    public DateTime Year { get; set; }
    public VehicleType Type { get; set; } = VehicleType.Wagon; 

    //public float CalculateMileage() => 0.0f;
}