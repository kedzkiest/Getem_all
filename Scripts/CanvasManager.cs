using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Canvas stageClearCanvas;
    public static bool stageClearCanvas_flag = false;

    public Canvas gameoverCanvas;
    public static bool gameoverCanvas_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        stageClearCanvas.enabled = false;
        gameoverCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(stageClearCanvas_flag == true){
            stageClearCanvas.enabled = true;
        }

        if(gameoverCanvas_flag == true){
            gameoverCanvas.enabled = true;
        }
    }
}
