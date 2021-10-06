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

    public class Fuel{
        int fuelLevel;

        public Fuel(int amount){
            fuelLevel = amount;
        }

        Fuel carFuel = new Fuel(100);
    }

    // Start is called before the first frame update
    void Start()
    {
        print("The model is " + carModel + " by " + carMaker + ", powered by a " + engineType);
        CheckWeight();
        
        if(yearMade <= 2009){
        print("The car was introduced in " + yearMade);
        int carAge = CalculateAge(yearMade);
        print("The car is " + carAge + " years old.");
        }else{
        print("The car is introduced in the 2010's");
        print("The maximum acceleration is " + maxAcceleration);
        }

        print(CheckCharacteristics());

    }

    void CheckWeight(){
        if(carWeight<1500){
            print(carModel + " weighs less than 1500");
        }else{
            print(carModel + " weighs more than 1500");
        }
    }

    string CheckCharacteristics(){
        if(isCarTypeSedan == true){
            return "The car is sedan.";
        }else if(hasFrontEngine == true){
            return "The car isn't sedan, but has a front engine.";
        }else{
            return "The car is neither sedan nor has a front engine.";
        }
    }


    int CalculateAge(int inputYear){
        int age = 2021-inputYear;
        return age;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
