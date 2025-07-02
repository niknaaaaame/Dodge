using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefeb;
    public float intervalMin = 0.5f;
    public float intercalMax = 3f;

    private Transform target;
    private float interval;
    private float timeAfterSpawn;
    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(intervalMin, intercalMax);
        timeAfterSpawn = 0f;

        //target = FindObjectOfType<Player>().transform;

        //target = GameObject.Find("Player").transform;

        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= interval)
        {
            GameObject bullet = Instantiate(bulletPrefeb, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            interval = Random.Range(intervalMin, intercalMax);
            timeAfterSpawn = 0f;
        }
    }
}
