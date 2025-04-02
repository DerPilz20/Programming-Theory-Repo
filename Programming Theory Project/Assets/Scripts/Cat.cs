using UnityEngine;

public class Cat : Animal // INHERITANCE
{
    void Awake()
    {
        jumpHeight = 4.0f;
        rb = GetComponent<Rigidbody>();
    }

    public override void Talk() // POLYMORPHISM
    {
        base.Talk();
        Debug.Log("MIAU");
    }

    void Update()
    {
        Walk();
        Jump();
        Talk();
    }
}
