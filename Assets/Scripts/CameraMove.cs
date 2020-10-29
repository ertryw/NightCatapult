using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    public GameObject target;
    public float smooth = 3;

    // Update is called once per frame
    void LateUpdate()
    {

        float xDist = target.transform.position.x + 1f;
        float yDist = target.transform.position.y;

        if (yDist < -2.2f)
            yDist = -2.2f;

        //lerp to follow player
        transform.position = Vector3.Lerp(transform.position, new Vector3(xDist, yDist, transform.position.z), smooth * Time.deltaTime);
    }

   
}
