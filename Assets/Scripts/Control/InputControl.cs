using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputControl : MonoBehaviour
{
    bool tap = false;

    public CircleCollider2D colision;

    public void OnCollisionStay2D(Collision2D other)
    {
        print("colisiona");
        if (other.gameObject.CompareTag("Rat") && tap )
        {
            print("chocar con rat");
            Destroy(other.gameObject);
            tap = false;
        }
    }

    public void TapRat()
    {
        tap = true;
    }
    public void MoveBox()
    {

    }

    public void MoveCursor()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
}
