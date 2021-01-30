using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitName : MonoBehaviour
{

    public GameObject text;

    public void Start()
    {
        PlayerPrefs.SetString("Name", "");
    }

    public void SubmitText()
    {
        PlayerPrefs.SetString("Name", text.GetComponent<UnityEngine.UI.Text>().text);
    }
}
