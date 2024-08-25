
using UnityEngine;
public class Dog : Animal
{
    private string name = "Doggy";
    public override void Eat()
    {
        Debug.Log("Eating bone");
    }
    public override void Sleep()
    {
        Debug.Log("Sleeping on the floor");
    }
}