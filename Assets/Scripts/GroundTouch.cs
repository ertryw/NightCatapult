using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTouch : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int touched;
    List<int> id_list = new List<int>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        print(collision.gameObject.name);
        IWall input;
        collision.gameObject.TryGetComponent<IWall>(out input);
        int instanceID = collision.gameObject.GetInstanceID();
        if (input != null && !id_list.Contains(instanceID))
        {
            id_list.Add(instanceID);
            touched++;
        }*/
    }
}
