using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmitScoreAnimation : MonoBehaviour
{
    public GameObject scoreImage;
    private Image image;

    private float alpha;
    // Start is called before the first frame update
    void Start()
    {
        alpha = 1.0f;
        image = scoreImage.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreImage.transform.Translate(0f, 3.0f, 0f);
        image.color = new Color(1, 1, 1, alpha);
        alpha -= 0.01f;
        if(alpha <= 0){
            Destroy(this.gameObject);
        }
    }
}
