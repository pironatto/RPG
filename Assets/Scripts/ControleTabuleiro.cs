using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleTabuleiro : MonoBehaviour
{

    public GameObject Player;
    public GameObject[] Grama;
   

    // Start is called before the first frame update
    void Start()
    {   
    
      Grama[0].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
