using System;

class Car
{
    // Car brand
    public string Brand { get; set; } // Arabanın markasını tutar

    // Car model
    public string Model { get; set; } // Arabanın modelini tutar

    // Car color
    public string Color { get; set; } // Arabanın rengini tutar

    // Door count (encapsulated field)
    private int doorCount; // Kapsüllenecek alan: kapı sayısı

    // Property with validation
    public int DoorCount
    {
        get { return doorCount; } // Kapı sayısını döndürür
        set
        {
            // Eğer 2 veya 4 girilirse kabul edilir
            if (value == 2 || value == 4)
            {
                doorCount = value;
            }
            else
            {
                // Geçersiz giriş için uyarı verilir ve -1 atanır
                Console.WriteLine(" Door count must be 2 or 4. Setting value to -1 by default.");
                doorCount = -1;
            }
        }
    }
}
