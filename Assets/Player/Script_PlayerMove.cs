using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerMove : MonoBehaviour
{
    public float BoundaryX = 20f;
    public float BoundaryY = 10.5f;
    public float Speed = 20f;
    public int Lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        moveShip();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        if (collided.tag == "Enemy")
        {
            Lives -= 1;
            if (Lives == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void moveShip()
    {
        Vector3 pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        pos.y += -Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        pos.z = -1;
        
        if (Mathf.Abs(pos.x) >= BoundaryX)
        {
            if (pos.x >= BoundaryX)
            {
                pos.x = BoundaryX;
            }
            else
            {
                pos.x = -BoundaryX;
            }
        }
        if (Mathf.Abs(pos.y) >= BoundaryY)
        {
            if (pos.y > BoundaryY)
            {
                pos.y = BoundaryY;
            }
            else
            {
                pos.y = -BoundaryY;
            }
        }
        transform.position = pos;
    }
}
