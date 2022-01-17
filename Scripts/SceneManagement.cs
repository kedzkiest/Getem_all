using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotoStage1(){
        CanvasManager.stageClearCanvas_flag = false;
        CanvasManager.gameoverCanvas_flag = false;
        PlayerController.sceneFlag = 1;
        SceneManager.LoadScene("Stage1");
    }

    public void gotoStage2(){
        CanvasManager.stageClearCanvas_flag = false;
        CanvasManager.gameoverCanvas_flag = false;
        PlayerController.sceneFlag = 2;
        SceneManager.LoadScene("Stage2");
    }

    public void gotoStage3(){
        CanvasManager.stageClearCanvas_flag = false;
        CanvasManager.gameoverCanvas_flag = false;
        PlayerController.sceneFlag = 3;
        SceneManager.LoadScene("Stage3");
    }

    public void gotoTitle(){
        CanvasManager.stageClearCanvas_flag = false;
        CanvasManager.gameoverCanvas_flag = false;
        PlayerController.sceneFlag = 0;
        SceneManager.LoadScene("Title");
    }
    
    public void exit(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
        #endif
    }
}
