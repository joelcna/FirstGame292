using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
        transform.position += new Vector3(xDirection, yDirection, 0) * Time.deltaTime * speed;
    }
    public void UpSpeed(float speed)
    {
        this.speed += speed;
    }
}
