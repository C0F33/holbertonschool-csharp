using System;
public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;


    public Dog(string name, float age, string owner, Rating rating)
    {
        name = name;
        age = age;
        owner = owner;
        rating = _rating;
    }

    public string name;
    public float age;
    public string owner;
    public Rating rating;
}