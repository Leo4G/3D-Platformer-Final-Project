using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float moveSpeed;
    public float rotationspeed;
    public float runSpeed = 10f;
    public float walkSpeed = 5f;
    public Vector3 movementInput;
    public Vector3 rotationInput;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //foward and back
         transform.position += transform.forward * Time.deltaTime * moveSpeed *  Input .GetAxisRaw("Vertical");
        // side to side
        transform.position += transform.right * Time.deltaTime * moveSpeed * Input .GetAxisRaw("Horizontal");
        //up
       if (Input .GetKey(KeyCode .Space))

        transform.position += Vector3.up * Time.deltaTime * moveSpeed;
        //sprinting (Used google to help make this code)
       if (Input.GetKey(KeyCode.LeftShift))
       {
       moveSpeed= runSpeed;
       }
       else
       {
        moveSpeed= walkSpeed;
       }
        // rotate right
        if (Input .GetKey(KeyCode .E))
      transform.eulerAngles += Vector3.up * Time.deltaTime * rotationspeed;
       // rotate left
        if (Input .GetKey(KeyCode .Q))
      transform.eulerAngles += Vector3.down * Time.deltaTime * rotationspeed;




    }
}
