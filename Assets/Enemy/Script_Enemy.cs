using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Enemy : MonoBehaviour
{
    public float BottomY = -15;
    public float Speed = 4f;
    public GameObject UI_handle;
    private Text score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject scoreKeeper = GameObject.Find("ScoreCounter");
        score = scoreKeeper.GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        boundary();
        spinCube();
        
    }

    private void boundary()
    {
        if (transform.position.y < BottomY)
        {
            Destroy(this.gameObject);
        }
    }
    private void spinCube()
    {
        Vector3 pos = transform.position;
        pos.y -= 1 * (Speed * Time.deltaTime);
        pos.z = -0.5f;
        transform.position = pos;
        transform.rotation = Quaternion.Euler(20f * Time.deltaTime, 20f * Time.deltaTime, 20f * Time.deltaTime) * transform.rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collided = collision.gameObject;
        if (collided.tag == "Bullet")
        {
            Destroy(this.gameObject);
            int _score = int.Parse(score.text);
            _score += 10;
            score.text = _score.ToString();


        }
        if (collided.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
