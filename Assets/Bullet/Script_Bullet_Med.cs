using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Bullet_Med : Script_Bullet
{
    public int hits = 2;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        if (collided.tag == "Enemy")
        {
            hits--;
        }
        if (hits <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
