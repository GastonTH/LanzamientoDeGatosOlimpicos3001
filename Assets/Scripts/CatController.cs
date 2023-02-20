using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{

    public Transform pivot;
    public float springRange;
    public float maxSpeed;
    private Rigidbody2D rb;
    bool canDrag;
    Vector3 dis;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        canDrag= true;
    }

    private void OnMouseDrag()
    {
        Debug.Log("Agarra");
        if (!canDrag)
        {
            return;
        }

        var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dis = pos - pivot.position;
        dis.z = 0;

        if (dis.magnitude > springRange)
        {
            dis = dis.normalized * springRange;
        }
        transform.position = dis + pivot.position;
    }

    private void OnMouseUp()
    {
        Debug.Log("Suelta");
        if (!canDrag) 
        {
            return;
        }

        canDrag= false;

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.velocity = dis.magnitude * maxSpeed * -dis.normalized / springRange;

    }
}