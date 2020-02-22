using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luz_mov : MonoBehaviour
{

    public float targetRotacion;
    public float rotateSpeed;
    public bool derecha = true;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        float angle = rotateSpeed * Time.deltaTime;


        if (transform.rotation.eulerAngles.z >= targetRotacion && transform.rotation.eulerAngles.z < 35 && derecha == true)
        {
            rotateSpeed = -rotateSpeed;
            derecha = false;
            
        }

        else if (transform.rotation.eulerAngles.z <= 360 - targetRotacion && transform.rotation.eulerAngles.z > 35 && derecha == false)
        {
            rotateSpeed = -rotateSpeed;
            derecha = true;

        }

        transform.rotation *= Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
