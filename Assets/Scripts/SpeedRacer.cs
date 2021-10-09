using UnityEngine;
using System;


public class SpeedRacer : MonoBehaviour
{

    //key features

    string carModel = "GTR35";
    string engineType = "V6, Twin Turbo";


    int carWeight = 1609;
    int yearMade = 2009;
    double maxAcceleration = 0.98;

  


    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {

        print("Car model: " + carModel + "\nEngine type: " + engineType);

        CheckWieght();

        if(yearMade <= 2009)
        {
            print(carModel + " was made in " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("So, " +carModel + " is now " + carAge + " years old!");
        }
        else
        {
            print("The car was introduced in the 2010’s");          // This information will be availbale  
            print("Maximum accerlatiosn is: " + maxAcceleration);   // only for the models built after 2010


            
        }

        print(checkCharactiristic());
    }

    void CheckWieght()
    {
        if (carWeight < 1500)
        {
            print(carModel + "'s weight is less than 1500 kg");
        }
        else if (carWeight > 1500)
        {
            print(carModel + "'s weight is more than 1500 kg");
        }
        else
        {
            print(carModel + "'s weight is exactrly 1500 kg"); // in case if wight (is) == 1500 kg)
        }
    }

    int CalculateAge(int yearMade)
    {
        return DateTime.Now.Year - yearMade;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    string checkCharactiristic()
    {

        if (isCarTypeSedan)
        {
            return "Yes it is Sedan!";
        } else if (hasFrontEngine)
        {
            return "The car isn’t a sedan, but has a front engine.";
        }
        else
        {

            return "The car is neither a sedan nor does it have a front engine.";
        }


    }
}
