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
        print($"The car model is {carModel} with an engine of type {engineType}");

        //check car's weight
        CheckWeight();

        //checking if car was introduced after 2010
        if(yearMade <= 2009)
        {
            int carAge = CalculateAge(yearMade);

            print($"This car was made in the year {yearMade}");

            print($"This car is {carAge} years old");
        }
        else
        {
            print("This car was probably introduced in the 2010s");

            print($"This car has a maximum acceleration of {maxAcceleration}, woo crazy fast / slow, I dunno!");
        }

        print(CheckCharacteristics());

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    //checks the car weight 
    void CheckWeight()
    {
        int maxWeight = 1500;

        if (carWeight < maxWeight)
        {
            print($"Car weight is less than {maxWeight}kg");
        }
        else
        {
            print($"Car weighs over {maxWeight}kg");
        }

    }

    //calculates the age of the car
    int CalculateAge(int yearMade)
    {
        return 2021 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan) return "This is a Sedan Car";

        if (hasFrontEngine) return "This isn't a Sedan Car, but it does have a front engine hm..";

        return "This Car isn't a Sedan and doesn't have a front engine";
    }
}
