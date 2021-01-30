using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetSize : MonoBehaviour
{

    public Text text;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        if (player !=null)
        {
            float size = PlayerPrefs.GetFloat("Size", 1f);
            player.localScale = new Vector3 (size,size,size);
            player.position = new Vector3(player.position.x, size, player.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (text != null)
        {
            text.text = PlayerPrefs.GetFloat("Size", 1f).ToString("F2");

        }
        if (SceneManager.GetActiveScene().name == "StartScreen" && player != null)
        {

            float size = PlayerPrefs.GetFloat("Size", 1f);
            player.localScale = new Vector3(size, size, size);
        }
    }

}
