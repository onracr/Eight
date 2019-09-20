using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Camera playerCamera = null;
    private Rigidbody playerRigidbody = null;

    public new string name;
    public float moveSpeed = 1.5f;
    public float lookSpeed = 50.0f;
    public float jumpForce = 2f;
    public float angularDrag = 10.0f;
    public Vector3 playerHeight = new Vector3(0f, -0.2f, 0f);


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.angularDrag = angularDrag;
        playerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ ;
        // gameObject.name = name;
        // Camera
        playerCamera.transform.rotation = transform.rotation;
    }

    void LateUpdate()
    {
        Movement();
        LookAround();
    }

    private void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * horizontal);
        transform.Translate(Vector3.forward * vertical);

        if (Input.GetButtonDown("Jump") == true)
            playerRigidbody.AddRelativeForce(Vector3.up * jumpForce, ForceMode.Impulse);

        if (Input.GetKey(KeyCode.LeftShift))
            moveSpeed = 10.0f;
        else
        {
            moveSpeed = 5.0f;
        }
        
    }

    private void LookAround()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.localRotation *= Quaternion.AngleAxis(mouseX * lookSpeed * Time.deltaTime, Vector3.up);
        playerCamera.transform.localRotation *= Quaternion.AngleAxis(mouseY * lookSpeed * Time.deltaTime, Vector3.left);

    }
    
}
