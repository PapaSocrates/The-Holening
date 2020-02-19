using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratAppear : MonoBehaviour
{

    public GameObject ratBase;
    public float ratPositionX;
    public float ratPositionY;
    public float firstWaitTime;
    public float minWaitTime;
    public float maxWaitTime;
    public float waitForSpawn;
    public bool spawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ratSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        waitForSpawn = Random.Range(minWaitTime, maxWaitTime + 1); 
    }

    IEnumerator ratSpawner()
    {
        yield return new WaitForSeconds(firstWaitTime);

        while (spawn)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-ratPositionX, +ratPositionX + 1), Random.Range(-ratPositionY, ratPositionY + 1));
            
            RaycastHit2D hit = Physics2D.CircleCast(new Vector2 (spawnPos.x, spawnPos.y -1), 1f, Vector2.up);
            Debug.DrawRay(spawnPos, Vector2.up , Color.green, 5);

            while (hit)
            {
                spawnPos = new Vector2(Random.Range(-ratPositionX, +ratPositionX + 1), Random.Range(-ratPositionY, ratPositionY + 1));
                hit = Physics2D.CircleCast(new Vector2(spawnPos.x, spawnPos.y - 1), 1f, Vector2.up);
                Debug.DrawRay(spawnPos, Vector2.up , Color.red, 5);
            }

            Instantiate(ratBase, spawnPos, gameObject.transform.rotation);
            yield return new WaitForSeconds(waitForSpawn);

        }

    }
}
