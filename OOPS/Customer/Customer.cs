using System;
namespace ClassesApp;

public class Customer
{

    private static int count;
    private readonly int id;
    public int Id { get { return id;} }
    private string _password;
    public string Password { set {
        this._password = value;
    } }
    
    
    
    public string Name { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string ContactNumber { get; set; }


    //default constructor
    public Customer()
    {
        Name = "NONAME";
        Address = "NO Address";
        ContactNumber = "NO Contact";
        id = count++;    
    }


    public Customer(string name,string address,string contactNumber): this()
    {
        this.Address = address;
        this.Name  =  name;
        this.ContactNumber = contactNumber;
    }

    //this is calling the default constructor using the this keyword.

    public Customer(string name) : this()
    {
        this.Name = name;
    }
    


    //default parameters, contactNumber
    public void UpdateDetails(string name, string address, string contactNumber = "NA"){
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void getDetails(){
        Console.WriteLine("Details about customer:" + Name + " address : " +  Address + " contact : " + ContactNumber + " age :" + Age + " :id " + id  + "Password" + _password);
    }
    

}
