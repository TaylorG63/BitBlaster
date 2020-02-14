using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Spawner : MonoBehaviour
{
    public GameObject SpawnEnemy;
    public float border = 20;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnEnemy", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnEnemy()
    {
        GameObject enemy = Instantiate<GameObject>(SpawnEnemy);
        Vector3 pos = new Vector3(Random.Range(-border, border), 17);
        enemy.transform.position = pos;
        Invoke("spawnEnemy", 2f);
    }
}
