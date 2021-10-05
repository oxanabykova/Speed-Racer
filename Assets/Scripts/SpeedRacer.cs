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

    // Start is called before the first frame update
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
}
