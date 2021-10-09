using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";

    int carWeight = 1609;
    int yearMade = 2009;

    float maxAcceleration = 0.98f;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    void Start()
    {
        print("The car model is " + carModel + ".");
        print("The car engine type is " + engineType + ".");

        CheckWeight();
        
        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade +".");
            int carAge = CalculateAge(yearMade);
            print("The car is " + carAge + " year old.");
        }
        else
        {
            print("The car was introduced in the 2010�s.");
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
        if(isCarTypeSedan)
        {
            return "The car type is Sedan.";
        }
        else if(hasFrontEngine)
        {
            return "The car is not a sedan, but has a front engine.";
        }
        else
        {
            return "The car is neither a sedan nor does it have a front engine.";
        }
    }
}
