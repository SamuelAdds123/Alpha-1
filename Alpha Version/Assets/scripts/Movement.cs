using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Sphere;
    public GameObject cube;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Sphere.transform.position = Vector3.MoveTowards(Sphere.transform.position, cube.transform.position, speed);
    }
}
