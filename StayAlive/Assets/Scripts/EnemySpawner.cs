using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float SpawnInterval = 4;
    public GameObject Player;


    private float spawnTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        int rnd = Random.Range(2, 2);
        InvokeRepeating("SpawnEnemy", rnd, rnd);
    }

    // Update is called once per frame
    void Update()
    {
        this.spawnTimer += Time.deltaTime;
    }

    void SpawnEnemy()
    {
        var enemy = GameObject.Instantiate(this.Enemy);
        Vector3 pos = new Vector3(Random.value - 0.5f, 0, Random.value - 0.5f).normalized * Random.Range(20, 20);
        enemy.transform.position = pos;

        enemy.GetComponent<Enemy>().Target = this.Player;

    }
}
