using System;
using System.Diagnostics;

public class Fraction{

    // Attributes/Properties
    private int top;
    private int bottom;

    // Constructors
    public Fraction()
    {
        this.top = 1;
        this.bottom = 1;
    }
    public Fraction(int top){
        this.top = top;
        this.bottom = 1;
    }
    public Fraction(int top, int bottom){
        this.top = top;
        this.bottom = bottom;
    }

    // Methods
    public string GetFractionString(){
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue(){
        return (double)top / (double)bottom;
    }

    // Getters and Setters
    public int GetTop(){
        return top;
    }
    public int GetBottom(){
        return bottom;
    }
}