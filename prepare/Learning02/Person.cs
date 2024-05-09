using System;

// Define class
class Person{

    // Define attributes
    public string givenName;
    public string familyName;

    // Constructor
    public Person(string givenName, string familyName) {
        this.givenName = givenName;
        this.familyName = familyName;
    }

    // Define methods
    public void EasternStyleName(){
        Console.WriteLine($"{this.familyName}, {this.givenName}");
    }
    public void WesternStyleName(){
        Console.WriteLine($"{givenName} {familyName}");
    }
}