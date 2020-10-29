using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ShotController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Vector3 vector3;
    [SerializeField] GameObject org;
    public FloatReference Bullets;
    public float rotation_speed;
    float origin_rotation_speed;
    Quaternion orgin_rot;
    Vector3 orgin_transform;
    public UnityEvent bullet_reset;
    public float power;
    public Slider power_slider;
    public Rigidbody2D bullet_rb;

    public bool shot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        orgin_rot = transform.rotation;
        orgin_transform = transform.position;
        origin_rotation_speed = rotation_speed;
    }


    public void rotateRigidBodyAroundPointBy(Rigidbody2D rb, Vector3 origin, Vector3 axis, float angle)
    {
        Quaternion q = Quaternion.AngleAxis(angle, axis);
        rb.MovePosition(q * (rb.transform.position - origin) + origin);
        rb.MoveRotation(rb.transform.rotation * q);
    }


    public void ResetPositon()
    {
        transform.rotation = orgin_rot;
        transform.position = orgin_transform;
        rotation_speed = origin_rotation_speed;
        bullet_reset.Invoke();
        shot = false;
        print("Reset");
    }

    // Update is called once per frame
    void Update()
    {

        if (Bullets.Variable.Value > 0 && bullet_rb.velocity.sqrMagnitude <= 0.1f && shot == false)
        { 
            if (Input.GetKey(KeyCode.Space))
            {
                power += Time.deltaTime * 8;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                SoundMenager.PlayCatapultShow();
                shot = true;
            }
        }

        power_slider.value = power;
    }


    private void FixedUpdate()
    {
        if (shot)
            Shot();
    }

    void Shot()
    {
        rotateRigidBodyAroundPointBy(rb, org.transform.position, new Vector3(0, 0, 1), -power);
    }

}

