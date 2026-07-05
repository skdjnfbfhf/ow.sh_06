using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;

    Rigidbody Mrb;
    Vector3 m_Movement;


    // Start is called before the first frame update
    void Start()
    {
        Mrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        m_Movement = new Vector3(horizontal, 0, vertical).normalized;

        transform.position += m_Movement * speed * Time.deltaTime;
    }
}
