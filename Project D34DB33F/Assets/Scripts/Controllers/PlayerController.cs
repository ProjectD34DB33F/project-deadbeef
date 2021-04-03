using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    //[SerializeField] Joystick joystick;
    [SerializeField] float speed = 6f;

    [SerializeField]
    KeyCode KeyAddItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");                          //joystick.Horizontal;
        float vertical = Input.GetAxisRaw("Vertical");                              //joystick.Vertical;
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
