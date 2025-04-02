using UnityEngine;

public class Animal : MonoBehaviour
{
    private float speed = 4.0f;
    protected float jumpHeight;
    protected Rigidbody rb;

    public void Walk()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    public virtual void Talk()
    {
        Debug.Log("Animal is making a sound");
    }
}
