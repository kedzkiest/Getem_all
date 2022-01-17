using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeChanger : MonoBehaviour
{
    public static int selectedCostume;
    public Material[] costumes;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Renderer>().material = costumes[selectedCostume];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
