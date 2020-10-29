using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct UIBind_Text { public Text UIElement; public FloatReference ScriptableObject; }

public class UIController : MonoBehaviour
{
    public UIBind_Text[] UiBinds;

    void Start()
    {
        
    }

    void Update()
    {
        updateBinds_Text();
    }


    void updateBinds_Text()
    {
        foreach (var  item in UiBinds)
        {
            if (item.UIElement != null && item.ScriptableObject != null)
                item.UIElement.text = item.ScriptableObject.Variable.Value.ToString();
        }
    }


}


