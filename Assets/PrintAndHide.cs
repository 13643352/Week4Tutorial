using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        i++;
        UnityEngine.Debug.Log(gameObject.name + ": " + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);

        }
        else if (gameObject.tag == "Blue" && (i >= 200 && i <= 250 ))
        {

            rend.enabled = false;
        }

    }
}
