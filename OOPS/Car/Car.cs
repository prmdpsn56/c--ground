using System;

namespace ClassesApp;


//internal : we can only use the class within the same assemply/program
internal  class Car

{       

    private string _brand = "";
    private string _name = "";
    private bool _luxury;


   public string Name { get; set; }   
    
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
    

    public bool  isLuxury
    {
        get => _luxury;
        set => _luxury = value;
    }


    public Car(string carName,string brand,bool isLuxury ){
        this._name = carName;
        this.Brand = brand;
        this.isLuxury = isLuxury;
        
        System.Console.WriteLine($"{_brand},  {_name} is created and it is considered as luxury: {_luxury};");
    }
}
