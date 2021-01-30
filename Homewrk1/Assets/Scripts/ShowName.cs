using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = PlayerPrefs.GetString("Name", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
