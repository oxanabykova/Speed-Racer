using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    //variable declaration A3.2
    public string carMaker;

    //variable declaration A3.1
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    //Declare class Fuel to store the fuel levels
    public class Fuel
    {
        public int fuelLevel;

        //Default constructor
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

    }

    //Declare a variable of type Fuel
    public Fuel carFuel = new Fuel(100);

    // Start is called before the first frame update
    void Start()
    {
        //print car model and engine type
        print("The racer model is " + carModel + carMaker + ". It has a " + engineType + " engine.");
        CheckWeight();
        if(yearMade <= 2009)
        {
            print("It was first introduced in " + yearMade);
            int age = CalculateAge(yearMade);
            print("That makes it " + age + " years old");
        }
        else
        {
            print("The car was introduced in the 2010’s.");
            print("The car’s maximum acceleration is " + maxAcceleration + "m/s2");

        }
        print(CheckCharacteristics());
    }

    // Update is called once per frame
    void Update()
    {
        //The action gets activated if you press on the space bar
        if (Input.GetKeyDown("space"))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }

    //Check if weight of the car is less or more than 1500
    void CheckWeight()
    {
        if (carWeight < 1500)
            print("the " + carModel + " weighs less than 1500 kg.");
        else
            print("the " + carModel + " weighs over 1500 kg.");
    }

    //Calculate the age of the car from the current year 2021
    int CalculateAge(int year)
    {
        return 2021 - year;
    }

    //Check if the car is sedan or not
    string CheckCharacteristics()
    {
        if(isCarTypeSedan)
            return "The car type is a sedan.";
        else
        {
            if (hasFrontEngine)
            {
                return "The car isn’t a sedan, but has a front engine.";
            }
            else
                return "The car is neither a sedan nor does it have a front engine.";
        }
    }

    void ConsumeFuel()
    {
        //every time we invode the function the level of fuel will be reduced by 10
        carFuel.fuelLevel -= 10;
    }

    void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two - thirds.");
                break;
            case 50:
                print("Fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("There’s nothing to report.");
                break;

        }
    }

}
