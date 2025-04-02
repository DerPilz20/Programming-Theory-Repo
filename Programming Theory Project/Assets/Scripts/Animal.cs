using UnityEngine;

public class Animal : MonoBehaviour
{
    private float speed = 4.0f; // ENCAPSULATION
    protected float jumpHeight; // ENCAPSULATION
    protected Rigidbody rb; // ENCAPSULATION

    public void Walk() // ABSTRACTION
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void Jump() // ABSTRACTION
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    public virtual void Talk() // POLYMORPHISM // ABSTRACTION
    {
        Debug.Log("Animal is making a sound");
    }
}
