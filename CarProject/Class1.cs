class Program
{
    static void Main(string[] args)
    {
        // First car object
        Car car1 = new Car(); // Yeni bir araba nesnesi oluşturulur
        car1.Brand = "Toyota"; // Marka atanır
        car1.Model = "Corolla"; // Model atanır
        car1.Color = "White"; // Renk atanır
        car1.DoorCount = 4; // Geçerli kapı sayısı atanır

        // Print car info
        Console.WriteLine($"{car1.Brand} {car1.Model} - Color: {car1.Color}, Door Count: {car1.DoorCount}");

        // Second car with invalid door count
        Car car2 = new Car(); // Yeni bir araba nesnesi
        car2.Brand = "Ford";
        car2.Model = "Fiesta";
        car2.Color = "Blue";
        car2.DoorCount = 3; // Geçersiz değer atanıyor

        // Print car info (after encapsulation check)
        Console.WriteLine($"{car2.Brand} {car2.Model} - Color: {car2.Color}, Door Count: {car2.DoorCount}");
    }
}
