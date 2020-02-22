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
    public int tries;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ratSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        if (globals.highscore < 10)
        {
            waitForSpawn = Random.Range(minWaitTime - 0.1f - globals.highscore, maxWaitTime + 1 - globals.highscore);
        }
        else
        {
            waitForSpawn = Random.Range(0.1f, 1);
        }
         
    }

    IEnumerator ratSpawner()
    {
        yield return new WaitForSeconds(firstWaitTime);

        while (spawn)
        {
            tries = 0;
            Vector2 spawnPos = new Vector2(Random.Range(-ratPositionX, ratPositionX + 1), Random.Range(-ratPositionY - 2.6f, ratPositionY + 0.3f));

            bool hit = Physics2D.OverlapCircle(new Vector2(spawnPos.x, spawnPos.y - 1), 1f);
            Debug.DrawRay(spawnPos, Vector2.up , Color.green, 5);

            while (hit && tries <3)
            {
                spawnPos = new Vector2(Random.Range(-ratPositionX, ratPositionX + 1), Random.Range(-ratPositionY - 2.7f, ratPositionY + 0.3f));
                hit = Physics2D.OverlapCircle(new Vector2(spawnPos.x, spawnPos.y - 1), 1f);
                Debug.DrawRay(spawnPos, Vector2.up , Color.red, 5);
                tries += 1;
            }
            if (tries < 3)
            {
                Instantiate(ratBase, spawnPos, gameObject.transform.rotation);
            }

            yield return new WaitForSeconds(waitForSpawn);
        }

    }
}
