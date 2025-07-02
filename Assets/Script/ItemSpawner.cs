using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ItemSpawner : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float intervalMin = 1f;
    public float intercalMax = 3f;

    private float interval;
    private float timeAfterSpawn;
    private float xPosition;
    private float zPosition;
    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(intervalMin, intercalMax);
        timeAfterSpawn = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= interval)
        {
            xPosition = Random.Range(-8f, 8f);
            zPosition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(xPosition, 10f, zPosition);
            GameObject Item = Instantiate(ItemPrefab, spawnPosition, transform.rotation);
         
            interval = Random.Range(intervalMin, intercalMax);
            timeAfterSpawn = 0f;
        }
    }
}
