using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Bullet : MonoBehaviour
{
    public float TopBorder = 15f;
    public float Speed = 30f;
    private Vector3 bulletVel = Vector3.zero;
    private void FixedUpdate()
    {
        if (Mathf.Abs(transform.position.y) >= TopBorder || Mathf.Abs(transform.position.x) >= 25)
        {
            Destroy(this.gameObject);
        }
        bulletVel.y = 1 * Speed * Time.deltaTime;
        transform.Translate(bulletVel);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        if (collided.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
