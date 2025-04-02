using UnityEngine;

public class Dog : Animal // INHERITANCE
{
   
    void Awake()
    {
        jumpHeight = 2.0f;
        rb = GetComponent<Rigidbody>();
    }

    public override void Talk() // POLYMORPHISM
    {
        base.Talk();
        Debug.Log("WAU");
    }

    void Update()
    {
        Walk();
        Jump();
        Talk();
    }
}
