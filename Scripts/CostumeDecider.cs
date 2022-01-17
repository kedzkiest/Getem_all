using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostumeDecider : MonoBehaviour
{
    public int option;
    public Toggle toggle;
    
    // Start is called before the first frame update
    void Start()
    {
        CostumeChanger.selectedCostume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggle != null && toggle.isOn)
        {
            CostumeChanger.selectedCostume = option;
        }
    }
}
