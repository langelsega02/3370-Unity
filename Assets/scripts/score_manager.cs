using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score_manager : MonoBehaviour
{
    public static score_manager instance;
    public TMP_Text score_text; //if using text mesh pro use this data type, if just using text, just use text data type
    int score = 0;
    

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        score_text.text = score.ToString() + " Points";

    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    public void addPoints()
    {
        score += 1;
        score_text.text = score.ToString() + " Points";
    }

}
