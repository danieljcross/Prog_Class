using System;

public class Job{

    // Attributes
    public string company;
    public string jobTitle;
    public string startYear;
    public string endYear;

    // Constructor
    public Job(string company, string jobTitle, string startYear, string endYear){
        this.company = company;
        this.jobTitle = jobTitle;
        this.startYear = startYear;
        this.endYear = endYear;
    }

    // Methods
    public void Display(){
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}