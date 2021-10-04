using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    private string carModel = "GTR R35";
    private string engineType = "V6, Twin Turbo";
    private int carWeight = 1609;
    private int yearMade = 2009;
    private float maxAcceleration = 0.98f;
    private bool isCarTypeSedan = false;
    private bool hasFrontEngine = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the racer model is " + carModel + ". It has a " + engineType + " engine.");
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
}
