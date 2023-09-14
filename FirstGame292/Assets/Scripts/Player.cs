using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float yPosition;
    [SerializeField] GameObject laser;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public float dashSpeed = 10f;
    [SerializeField] public float dashDuration = 0.25f;
    [SerializeField] public float dashCooldown = 1f;
    private bool canDash = true;

    // Start is called before the first frame update
    void Start()
    {
        yPosition = transform.position.y;
    }
    
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("FireLaser"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && canDash && moveDirection != Vector3.zero)
        {
            Dash(moveDirection);
        }
    }

    void Dash(Vector3 dashDirection)
    {
        canDash = false;
        Vector3 dashVelocity = dashDirection * dashSpeed;
        transform.position += dashVelocity * dashDuration;
        Invoke("ResetDashCooldown", dashCooldown);
    }

    void ResetDashCooldown()
    {
        canDash = true;
    }
}
