using UnityEngine;
public class Cat : Animal
{
    private string name = "Kitty";
    public override void Eat()
    {
        Debug.Log("Eating fish");
    }
    public override void Sleep()
    {
        Debug.Log("Sleeping on the sofa");
    }
}