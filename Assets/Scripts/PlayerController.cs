using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController playerCc;
    public float speed = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        playerCc.Move(move * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
