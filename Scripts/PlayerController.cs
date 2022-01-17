using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody rigidbody;
    public AudioClip getPointSound;
    public AudioClip wallCollisionSound;
    public AudioClip stageClearSound;
    public AudioSource audioSource;

    public static int sceneFlag = 0;

    public Text stage_ScoreText;
    public GameObject scoreImage;

    private int stage1_ClearPoint = 15;
    private int stage2_ClearPoint = 10;
    private int stage3_ClearPoint = 15;
    static int countPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        countPoint = 0;
        rigidbody = this.GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force;
        
        if(Input.GetKey(KeyCode.UpArrow)){
            force = new Vector3(0, 0, speed);
            this.rigidbody.AddForce(force, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            force = new Vector3(0, 0, -speed);
            this.rigidbody.AddForce(force, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            force = new Vector3(speed, 0, 0);
            this.rigidbody.AddForce(force, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            force = new Vector3(-speed, 0, 0);
            this.rigidbody.AddForce(force, ForceMode.Force);
        }
        
        /* jump for debug
        if(Input.GetKeyDown(KeyCode.Space)){
            force = new Vector3(0, 250, 0);
            this.rigidbody.AddForce(force, ForceMode.Force);
        }
        */

        if(sceneFlag == 1){
            stage_ScoreText.text = countPoint.ToString() + "/" + stage1_ClearPoint.ToString() + " points";
        }
        else if(sceneFlag == 2){
            stage_ScoreText.text = countPoint.ToString() + "/" + stage2_ClearPoint.ToString() + " points";
        }
        else if(sceneFlag == 3){
            stage_ScoreText.text = countPoint.ToString() + "/" + stage3_ClearPoint.ToString() + " points";
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Point")){
            audioSource.PlayOneShot(getPointSound);
            Destroy(other.gameObject);
            countPoint++;
            emitScore();
            if(sceneFlag == 1){
                if(countPoint >= stage1_ClearPoint){
                    CanvasManager.stageClearCanvas_flag = true;
                    audioSource.PlayOneShot(stageClearSound);
                    Destroy(GameObject.Find("Enemy"));
                }
            }
            else if(sceneFlag == 2){
                if(countPoint >= stage2_ClearPoint){
                    CanvasManager.stageClearCanvas_flag = true;
                    audioSource.PlayOneShot(stageClearSound);
                    Destroy(GameObject.Find("Enemy"));
                }
            }
            else if(sceneFlag == 3){
                if(countPoint >= stage3_ClearPoint){
                    CanvasManager.stageClearCanvas_flag = true;
                    audioSource.PlayOneShot(stageClearSound);
                    Destroy(GameObject.Find("Enemy"));
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "DeathWall"){
            CameraMove.playerExist = false;
            CanvasManager.gameoverCanvas_flag = true;
            Destroy(this.gameObject);
        }

        if(collision.gameObject.tag == "Wall"){
            audioSource.PlayOneShot(wallCollisionSound);
        }
    }

    void emitScore(){
        GameObject cloneObject = Instantiate(scoreImage, Vector3.zero, Quaternion.identity);

        cloneObject.transform.SetParent(GameObject.Find("PlayerScore_Canvas").transform);
        cloneObject.transform.localRotation = Quaternion.identity;
        cloneObject.transform.localPosition = new Vector3(0f, -141f, 0f);
    }

    public static int checkGetPoint(){
        return countPoint;
    }
}
