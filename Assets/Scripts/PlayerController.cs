using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

  private ControleTabuleiro _controleTabuleiro;
  private Rigidbody2D rbPlayer;
  private Animator playerAnimator;
  [HideInInspector]
  public bool selecionar,clicar;
  [HideInInspector]
  public bool Move;
 

    // Start is called before the first frame update
    void Start()
    {
      _controleTabuleiro = ControleTabuleiro.FindObjectOfType(typeof(ControleTabuleiro)) as ControleTabuleiro;
      rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {     
       playerAnimator = GetComponent<Animator>();
    }

    void Update(){  

        // PARA SELECIONAR O PERSONAGEM
       if(Input.GetMouseButton(0) && selecionar){
            clicar = true;  
         }   
      }     
      
      void LateUpdate() {
           playerAnimator.SetBool("move",Move);

    }

      //PARA MOVIMENTAR O PERSONAGEM AO LOCAL DESEJADO, CONFORME DEFINIDO NO GAMECONTROLLER
     public void MovePlayer(){
            transform.position = Vector2.MoveTowards(transform.position,new Vector2(_controleTabuleiro.PosicaoFinal.x,_controleTabuleiro.PosicaoFinal.y+0.5f),2* Time.deltaTime);
            Move = true;
              if(transform.position.x == _controleTabuleiro.PosicaoFinal.x && transform.position.y == _controleTabuleiro.PosicaoFinal.y+0.5f){
                Move = false;
                _controleTabuleiro.selecionado = false;     
              }

             } 


        void OnMouseEnter() {        
           selecionar = true;
     }

        void OnMouseExit() {
          selecionar = false;        
        }


   

}