using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;


    void Start()
    {
        Debug.Log("Car: "+carModel+" | Brand: "+carMaker+" | Engine: "+engineType);
        CheckWeight();
        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            print("The age of the car is " + carAge);
        }
        else
        {
            print("he car was introduced in the 2010’s");
            print("the car’s maximum acceleration is " + maxAcceleration);
        }
        print(CheckCharacteristics());
    }

    // Update is called once per frame
    void Update()
    {
        void ConsumeFuel()
        {
            carFuel.fuelLevel = carFuel.fuelLevel - 10;
        }
        void CheckFuelLevel()
        {
            switch (carFuel.fuelLevel)
            {
                case 70: 
                    print("fuel level is nearing two-thirds");
                    break;
                case 50:
                    print("fuel level is at half amount");
                    break;
                case 10:
                    print("Warning! Fuel level is critically low");
                    break;
                default:
                    print("there's nothing to report");
                    break;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel + " weighs less than 1500 kg");
        } 
        else 
        {
            print(carModel + " weighs over 1500 kg");
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
            return "The car is a sedan";
        } 
        else if (hasFrontEngine) {
            return "The car is not sedan, but it has a front engine";
        }
        else
        {
            return "The car is neither a sedan nor does it have a front engine";
        }
    }
    public class Fuel
    {
        public int fuelLevel;
        public Fuel (int amount)
        {
            fuelLevel = amount;
        }
    }
    public Fuel carFuel = new Fuel(100);
}
