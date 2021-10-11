using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;
    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public string carMaker;

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);

    void Start()
    {
        print("The car is produced by " + carMaker + ".");
        print("The car model is " + carModel + ".");
        print("The car engine type is " + engineType + ".");

        CheckWeight();

        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade + ".");
            int carAge = CalculateAge(yearMade);
            print("The car is " + carAge + " year old.");
        }
        else
        {
            print("The car was introduced in the 2010’s.");
            print("It maximum acceleration is " + maxAcceleration);
        }

        print(CheckCharacteristics());
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The " + carModel + " weighs less than 1500 kg.");
        }
        else
        {
            print("The " + carModel + " weighs over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car type is Sedan.";
        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, but has a front engine.";
        }
        else
        {
            return "The car is neither a sedan nor does it have a front engine.";
        }
    }

    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }

    void CheckFuelLevel()
    { 
        switch(carFuel.fuelLevel)
        {
        case 70:
            print("fuel level is nearing two-thirds.");
            break;
        case 50:
            print("fuel level is at half amount.");
            break;
        case 10:
            print("Warning! Fuel level is critically low!");
            break;
        default:
            print("There’s nothing to report");
            break;
        }
    }
    
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        if (down)
        {
            ConsumeFuel();
            CheckFuelLevel();
        }

    }

}
