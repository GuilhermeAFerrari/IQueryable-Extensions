using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;
using System.Text.Json;

namespace IQueryable.Repositories
{
    public static class CarRepository
    {
        public static IEnumerable<Car> GetCar()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Car.json");
            var jsonString = File.ReadAllText(path);
            var jsonData = JsonSerializer.Deserialize<IEnumerable<Car>>(jsonString);
            if (jsonData != null)
                return jsonData;
            else
                return Enumerable.Empty<Car>();
        }
    }
}
