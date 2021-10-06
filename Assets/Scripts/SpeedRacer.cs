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
        print("The model is " + carModel + ", powered by a " + engineType);
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
