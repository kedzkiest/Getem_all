using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedHeadLight : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Player != null){
            this.gameObject.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 5.0f, Player.transform.position.z);
        }
        else{
            Destroy(this.gameObject);
        }
    }
}
