using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conductaRatuna : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    public GameObject ratatui;
    public int timeToRat;
    public int timeToBreak;

    void Start()
    {
        StartCoroutine(ratatuiSpawner());
    }

    // Update is called once per frame
    IEnumerator ratatuiSpawner()
    {


        yield return new WaitForSeconds(timeToRat);
        Instantiate(ratatui, transform.position, transform.rotation);
        globals.lives -= 1;
        yield return new WaitForSeconds(timeToBreak);
        Destroy(this.gameObject);
    }
}
