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

    // Start is called before the first frame update
    void Start()
    {
        print($"The car model is {carModel} with an engine of type {engineType}");

        CheckWeight();

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

}
