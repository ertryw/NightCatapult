using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 origin_position;

    // Start is called before the first frame update
    void Start()
    {
        origin_position = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = origin_position; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
