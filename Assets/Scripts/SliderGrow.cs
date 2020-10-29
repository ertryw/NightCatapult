using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderGrow : MonoBehaviour
{
    Slider sl;
    // Start is called before the first frame update
    void Start()
    {
        sl = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        sl.transform.localScale = new Vector3(1 +  sl.value/4, 1 + sl.value / 4, 1 + sl.value / 4);
    }
}
