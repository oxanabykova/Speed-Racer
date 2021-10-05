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
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the racer model is " + carModel + " " + carMaker + ". It has a " + engineType + " engine.");
        CheckWeight();

        if(yearMade <= 2009)
        {
            Debug.Log("the car was introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            Debug.Log("That makes it " + carAge + " years old.");
        }
        else
        {
            Debug.Log("the car was introduced in the 2010’s");
            Debug.Log("Car´s maxium acceleration is " + maxAcceleration);
        }

        Debug.Log(CheckCharacteristics());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void CheckWeight()
    {
        if (carWeight < 1500)
        {
            Debug.Log("The " + carModel + " weights less than 1500 kg.");
        }
        else
        {
            Debug.Log("The " + carModel + " weights over 1500 kg.");
        }
    }

    private int CalculateAge(int pYearMade)
    {
        return 2021 - pYearMade;
    }

    private string CheckCharacteristics()
    {
        if(isCarTypeSedan)
        {
            return "The car is a sedan.";
        }
        else
        {
            if (hasFrontEngine)
            {
                return "The car is not a sedan, but has a front engine.";
            }
            else
            {
                return "The car is neither a sedan nor does it have a front engine.";
            }
        }
    }

    private void ConsumeFuel()
    {
        carFuel.fuelLevel =- 10;
    }

    private void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 10:
                {
                    Debug.Log("Warning! Fuel level is critically low.");
                    break;
                }
            case 50:
                {
                    Debug.Log("fuel level is at half amount.");
                    break;
                }
            case 70:
                {
                    Debug.Log("fuel level is nearing two-thirds.");
                    break;
                }
            default:
                {
                    Debug.Log("there’s nothing to report.");
                    break;
                }
        }
    }

    public class Fuel
    {
        public int fuelLevel;
        public Fuel(int pAmount)
        {
            fuelLevel = pAmount;
        }
    }

    Fuel carFuel = new Fuel(100);
}
