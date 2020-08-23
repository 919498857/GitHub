using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

        while (true) { 
            i++;
            Debug.Log(gameObject + ":" + i);
            if(gameObject.tag == "Red" && i == 100){
                break;
            }else if (gameObject.tag =="Blue" && 200<= i || i<= 250) {
                break;
            }
        }
    }
}