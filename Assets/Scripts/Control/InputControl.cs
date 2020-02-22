using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputControl : MonoBehaviour
{
    public Collider2D rat;
    bool killable = false;

    public CircleCollider2D colision;



    public void MoveBox()
    {

    }

    public void MoveCursor()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }

    public void TapRat()
    {
        if (colision.IsTouching(rat))
        {
            Destroy(rat.gameObject);
            globals.highscore++;
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Rat"))
        {
            killable = true;
            rat = other.gameObject.GetComponent<CircleCollider2D>();
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
