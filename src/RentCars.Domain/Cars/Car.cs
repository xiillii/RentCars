namespace RentCars.Domain.Cars;

public sealed class Car
{
    public Guid Id { get; private set; }
    public string? Vin { get; private set; }
    public string? Address { get; private set; }
    public string? City { get; private set; }
    public string? Country { get; private set; }

    public decimal Price { get; private set; }
    public string? Currency { get; private set; }

    public decimal MaintenancePrice { get; private set; }
    public string? MaintenanceCurrency { get; private set; }

    public DateTime? LastDateRent { get; private set; }

    public List<Accessory> Accessories { get; private set; } = new();

}
