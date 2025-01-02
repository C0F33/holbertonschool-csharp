using System;
public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{ 
    public Dog(string name, float age, string owner, Rating rating)
    {
        name = _name;
        age = _age;
        owner = _owner;
        rating = _rating;
    }

    public string name;
    public float age;
    public string owner;
    public Rating rating;
}