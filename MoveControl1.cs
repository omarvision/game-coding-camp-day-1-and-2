using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl1 : MonoBehaviour
{
    public float MoveSpeed = 3.5f;

    private void Update()
    {
        //moves me left and right
        float x = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * x * MoveSpeed * Time.deltaTime);

        //moves me forward and backward
        float z = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward * z * MoveSpeed * Time.deltaTime);
    }
}
