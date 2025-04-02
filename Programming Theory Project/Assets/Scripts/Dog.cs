using UnityEngine;

public class Dog : Animal
{
   
    void Awake()
    {
        jumpHeight = 2.0f;
        rb = GetComponent<Rigidbody>();
    }

    public override void Talk()
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
