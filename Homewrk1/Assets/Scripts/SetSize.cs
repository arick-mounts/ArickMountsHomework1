using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetSize : MonoBehaviour
{

    public Slider Slider;
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetFloat("Size", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SizeSetter()
    {
        PlayerPrefs.SetFloat("Size", Slider.value);
    }
}
