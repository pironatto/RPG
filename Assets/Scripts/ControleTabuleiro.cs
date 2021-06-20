using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleTabuleiro : MonoBehaviour
{

    private PlayerController _playerController;
    public GameObject Player;
    public GameObject[] Grama;
    public bool selecionar, clicar;
    public bool selecionado = false;
    private Vector2 NextPosition;
    public Vector2 PosicaoFinal;
    public string posGrama;
      
   

    // Start is called before the first frame update
    void Start()
    {      
      _playerController = FindObjectOfType(typeof(PlayerController))as PlayerController;      
     
    }

   // Update is called once per frame
    void Update()
    {
        //PARA SELECIONAR O GRAMADO DESEJADO
        if(Input.GetMouseButtonDown(0) && selecionar && _playerController.clicar){  
              clicar = true; 
              SetTargetPositon();                                                 
        }        
 
    }

    // VERIFICAR QUAL O GRAMADO O JOGADOR ESTÁ SELECIONANDO
    private void SetTargetPositon()
    {
        NextPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        selecionado = true;
        Collider2D col = Physics2D.OverlapCircle(NextPosition, 0.5f,LayerMask.GetMask("Tabuleiro"));
        PosicaoFinal = col.transform.position;
        posGrama = col.gameObject.name;        

    }

 

    void OnMouseEnter() {        
           selecionar = true;
        }
     
        void OnMouseExit() {
          selecionar = false;        
        }


}



