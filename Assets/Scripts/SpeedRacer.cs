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
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void CheckWeight()
    {
        if (carWeight < 1500)
        {
            Debug.Log("The " + carModel + "weights less than 1500 kg.");
        }
        else
        {
            Debug.Log("The " + carModel + "weights over 1500 kg.");
        }
    }

    private int CalculateAge(int pYearMade)
    {
        return 2021 - pYearMade;
    }
}
