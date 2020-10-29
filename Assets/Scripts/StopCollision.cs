using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCollision : MonoBehaviour
{
    public FloatReference Bullets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        ShotController input; 
        collision.gameObject.TryGetComponent<ShotController>(out input);
        if (input != null)
        {
            input.rotation_speed = 0;
            //input.shot = false;
            input.power = 0;
            Bullets.Variable.Value -= 1;
        }
    }


}
