using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public float Speed {
        get => Speed;
        set {
            if (value < 0) {
                Speed = 0;
            } else {
                Speed = value;
            }
        }
    }
    protected string species = "Animal";
    public abstract void Eat();
    public virtual void Eat(string food){
        Debug.Log("Eating " + food);
    }
    public virtual void Sleep(){
        Debug.Log("Sleeping");
    }
    public virtual void Drink(){
        Debug.Log("Drinking");
    }
}