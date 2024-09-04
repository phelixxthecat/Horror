using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody playerRigidBody;
    public float p_Speed = 5f;
    public float MouseX, MouseY, Angle;
    public Transform Body, Head;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = this.GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UnityEngine.Vector3 p_Input = new UnityEngine.Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerRigidBody.MovePosition(transform.position + p_Input * Time.deltaTime * p_Speed);
        
        MouseX = Input.GetAxis("Mouse X") * 100 * Time.deltaTime;
        Body.Rotate(UnityEngine.Vector3.up, MouseX);

        MouseY = Input.GetAxis("Mouse Y") * 100 * Time.deltaTime;
        Angle -= MouseY;
        Angle = Mathf.Clamp(Angle, -30, 45);

        Head.localRotation = UnityEngine.Quaternion.Euler(Angle, 0,0);
    }
}
