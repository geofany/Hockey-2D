using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    Text pemenang;
    void Start()
    {
        pemenang = GameObject.Find ("Pemenang").GetComponent<Text> ();
        pemenang.text = Data.pemenang;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
