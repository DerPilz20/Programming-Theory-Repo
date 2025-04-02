using UnityEngine;

public class Cat : Animal
{
    void Awake()
    {
        jumpHeight = 4.0f;
        rb = GetComponent<Rigidbody>();
    }

    public override void Talk()
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
