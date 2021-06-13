using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

  private ControleTabuleiro _controleTabuleiro;
  public bool selecionar;
  private Rigidbody2D rbPlayer;
 

    // Start is called before the first frame update
    void Start()
    {
      _controleTabuleiro = ControleTabuleiro.FindObjectOfType(typeof(ControleTabuleiro)) as ControleTabuleiro;
      rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rbPlayer.velocity = new Vector2(h,v);
    }

    void Update(){
     if(selecionar == true){        
            
            _controleTabuleiro.Grama[1].SetActive(true);
            _controleTabuleiro.Grama[2].SetActive(true);
            _controleTabuleiro.Grama[3].SetActive(true);            
          
      }
       else{
             _controleTabuleiro.Grama[1].SetActive(false);
             _controleTabuleiro.Grama[2].SetActive(false);
              _controleTabuleiro.Grama[3].SetActive(false);    
       }



     
    }


        void OnMouseEnter() {
         
           selecionar = true;
     }

        void OnMouseExit() {
          selecionar = false;  
        
        }
    

}
