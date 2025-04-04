using System;

namespace ClassesApp;


//internal : we can only use the class within the same assemply/program
internal  class Car

{       

    private string _brand = "";
    public string Brand
    {
        get {
            if(isLuxury){
                return _brand + " is a luxury brand";
            }
            return _brand;
        }

        set {
            if(String.IsNullOrEmpty(value)){
                this._brand = "DEFAULT Brand VALUE";
            }else{
                this._brand = value;
            }
        }
    }
    public static int NumberOfCars = 0;
    public string Model { get; set; }   
    public bool isLuxury { get; set; }

    public Car(string carName,string brand,bool isLuxury ){
        Model = carName;
        Brand = brand;
        this.isLuxury = isLuxury;
        NumberOfCars++;
    }


    public void Drive(){
        System.Console.WriteLine("I am driving");
    }



}
