using UnityEngine;
using UnityEngine.InputSystem;



public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;
    public Rigidbody rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("holi");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("chau");

        if (Keyboard.current.wKey.isPressed)
        {
            rigidbody.AddForce(Vector3.forward * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }


        if (Keyboard.current.sKey.isPressed)
        {
            rigidbody.AddForce(Vector3.back * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }

        if (Keyboard.current.aKey.isPressed)
        {
            rigidbody.AddForce(Vector3.left * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }
        
        if (Keyboard.current.dKey.isPressed)
        {
            rigidbody.AddForce(Vector3.right * Time.fixedDeltaTime * speed, ForceMode.Impulse);
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
    }
}
