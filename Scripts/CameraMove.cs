using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;

    public static bool playerExist;

    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("Player") != null){
            this.player = GameObject.Find("Player");
            playerExist = true;
        }
        else{
            playerExist = false;
        }
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerExist){
            transform.position = player.transform.position + offset;
        }
    }
}
