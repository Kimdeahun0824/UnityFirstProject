using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    Transform myTransform;
    public Transform Solar;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.RotateAround(Solar.position,Vector3.down,Time.deltaTime*moveSpeed);
    }
}
