using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public bool perdera= false;
    public TextMeshProUGUI perder;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ratSpawner());
        perder.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (globals.highscore < 20 && globals.lives > 0)
        {
            waitForSpawn = Random.Range(minWaitTime - 0.1f * globals.highscore, maxWaitTime + 1 - 0.2f * globals.highscore);
        }
        else if (globals.lives > 0)
        {
            waitForSpawn = Random.Range(0.3f, 1.3f);
        }
        else if (globals.lives <= 0 && perdera == false)
        {
            waitForSpawn = 10;
            perder.text = ("YOU LOSE \n" + "Highscore = " + globals.highscore);
            perdera = true;
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
