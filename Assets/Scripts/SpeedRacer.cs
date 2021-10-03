using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = " V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        print(carModel + engineType);
        CheckWeight();
        print (CheckCharacteristics());

        if (yearMade <= 2009)
        {
            print("Car was introduced in " + yearMade);
            int carAge = CalculateAge(yearMade);
            print("The car is " + carAge + " years old");
        }
        else
        {
            print("Car was introduced in the 2010's, ");
            print("It's max acceleration is " + maxAcceleration);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print(carModel + " weighs less than 1500kg");
        }
        else 
        {
            print(carModel + " weighs over 1500kg");
        }                
    }
    string CheckCharacteristics()
    {
        if (isCarTypeSedan == true)
        {
            return("Car type is sedan!");
        }

        else if (hasFrontEngine == true)
        {
            return("Not sedan, but has a front engine.");
        }

        else
        {
            return("Is not sedan and doesn't have a front engine.");
        }
    }


    int CalculateAge(int ageCalc)
    {
        ageCalc = 2021 - yearMade;
        return ageCalc;
    }

}
