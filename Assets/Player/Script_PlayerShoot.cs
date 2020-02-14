using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerShoot : MonoBehaviour
{
    public float PrimaryCoolDown = 0.2f;
    public float SecondaryCoolDown = 0.5f;
    public float TertiaryCoolDown = 1f;
    public GameObject PrimaryBullet;
    public GameObject SecondaryBullet;
    private float primaryCD = 0f;
    private float secoundCD = 0f;
    private float thirdCD = 0f;
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
        primaryFire();
        secoundFire();
        //thirdFire();
    }

    private void primaryFire()
    {
        if (primaryCD <= 0 && Input.GetButton("Fire1"))
        {
            primaryCD = PrimaryCoolDown;
            GameObject bulletPrime = Instantiate<GameObject>(PrimaryBullet);
            Vector3 pos = transform.position;
            pos.y += 1f;
            bulletPrime.transform.position = pos;
        }
        else if(primaryCD > 0)
        {
            primaryCD -= Time.deltaTime;
        }
    }
    private void secoundFire()
    {
        if (secoundCD <= 0 && Input.GetButton("Fire2"))
        {
            secoundCD = SecondaryCoolDown;
            GameObject bulletSecond = Instantiate<GameObject>(SecondaryBullet);
            Vector3 pos = transform.position;
            pos.y += 1f;
            bulletSecond.transform.position = pos;
        }
        else if (secoundCD > 0)
        {
            secoundCD -= Time.deltaTime;
        }
    }

    private void thirdFire()
    {
        if (thirdCD <= 0 && Input.GetButton("Fire3"))
        {
            thirdCD = TertiaryCoolDown;
            for (int i = 0; i < 3; i++)
            {
                GameObject bulletThird = Instantiate<GameObject>(SecondaryBullet);
                Vector3 pos = transform.position;
                pos.x += Mathf.Sin((Mathf.PI*i)/2);
                pos.y += Mathf.Cos((Mathf.PI * i) / 2);
                bulletThird.transform.position = pos;
                bulletThird.transform.rotation = Quaternion.Euler(0,0,(36*i)-45);
            }
        }
        else if (thirdCD > 0)
        {
            thirdCD -= Time.deltaTime;
        }
    }
}
