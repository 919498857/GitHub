using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PrintAndHide : MonoBehaviour
{
    public int i;
    public Renderer rend;
    public GameObject redObj;
    public GameObject blueObj;
    public int random;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        redObj.tag = "Red";
        blueObj.tag = "Blue";
        redObj.SetActive(true);
        blueObj.SetActive(true);
        random = UnityEngine.Random.Range(200,250);


    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject + ":" + i);




    }
}
