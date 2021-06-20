using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleTabuleiro : MonoBehaviour
{

    private PlayerController _playerController;
    private GameController _gameController;
    private Vector2 NextPosition;
    public GameObject Player;
    public GameObject[] Grama;
    [HideInInspector]
    public bool selecionar, clicar;
    [HideInInspector]
    public bool selecionado = false;
    [HideInInspector]
    public Vector2 PosicaoFinal;
    [HideInInspector]
    public string posGrama;



    // Start is called before the first frame update
    void Start()
    {
        _playerController = FindObjectOfType(typeof(PlayerController)) as PlayerController;
        _gameController = FindObjectOfType(typeof(GameController)) as GameController;

    }

    // Update is called once per frame
    void Update()
    {
        //PARA SELECIONAR O GRAMADO DESEJADO
        if (Input.GetMouseButtonDown(0) && selecionar && _playerController.clicar)
        {
            clicar = true;
            SetTargetPositon();
        }

    }

    // VERIFICAR QUAL O GRAMADO O JOGADOR ESTÁ SELECIONANDO
    private void SetTargetPositon()
    {
        NextPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        selecionado = true;
        Collider2D col = Physics2D.OverlapCircle(NextPosition, 0.5f, LayerMask.GetMask("Tabuleiro"));
        PosicaoFinal = col.transform.position;
        posGrama = col.gameObject.name;

    }

    void OnMouseEnter()
    {
        selecionar = true;
    }

    void OnMouseExit()
    {
        selecionar = false;
    }

    //CONTROLAR QUAL GRAMADO ESTARÁ ACESSO E DISPONIVEL PARA O PLAYER
    public void ControleGramaAcesa()
    {
                switch(_gameController.posPlayer){
               case "":
                 Grama[1].SetActive(true);
                 Grama[2].SetActive(true);
                 Grama[3].SetActive(true); 
               break;
               
                case "1":
                 Grama[1].SetActive(true);
                 Grama[4].SetActive(true);
                 Grama[5].SetActive(true);                 
                 Grama[6].SetActive(true);
                 Grama[0].SetActive(false);               
                 Grama[2].SetActive(false);
                 Grama[3].SetActive(false);
                break;

                case "2":
                 Grama[2].SetActive(true);
                 Grama[5].SetActive(true);
                 Grama[6].SetActive(true);                
                 Grama[7].SetActive(true);
                 Grama[0].SetActive(false); 
                 Grama[1].SetActive(false);              
                 Grama[3].SetActive(false);

                break;
                 case "3":
                 Grama[3].SetActive(true);
                 Grama[6].SetActive(true);
                 Grama[7].SetActive(true);                
                 Grama[8].SetActive(true);
                 Grama[2].SetActive(false);               
                 Grama[2].SetActive(false);    
                 Grama[1].SetActive(false);             
                 Grama[0].SetActive(false);             
                break;

                 case "4":
                 Grama[4].SetActive(true);
                 Grama[9].SetActive(true);
                 Grama[10].SetActive(true);
                 Grama[2].SetActive(false);    
                 Grama[1].SetActive(false);             
                 Grama[3].SetActive(false);                
            
                break;

                case "5":
                 Grama[5].SetActive(true);
                 Grama[9].SetActive(true);
                 Grama[10].SetActive(true);
                 Grama[11].SetActive(true);
                 Grama[6].SetActive(false);    
                 Grama[2].SetActive(false);             
                 Grama[3].SetActive(false);
                 Grama[4].SetActive(false);
                 Grama[7].SetActive(false); 


                break;
                                case "6":
                 Grama[6].SetActive(true);
                 Grama[12].SetActive(true);
                 Grama[10].SetActive(true);
                 Grama[11].SetActive(true);
                 Grama[2].SetActive(false); 
                 Grama[5].SetActive(false); 
                 Grama[7].SetActive(false); 


                break;
                                case "7":
                 Grama[7].SetActive(true);
                 Grama[11].SetActive(true);
                 Grama[12].SetActive(true);
                 Grama[13].SetActive(true);
                 Grama[5].SetActive(false);               
                 Grama[6].SetActive(false);
                 Grama[8].SetActive(false);
                 Grama[2].SetActive(false); 
                break;

                                case "8":
                 Grama[8].SetActive(true);
                 Grama[12].SetActive(true);
                 Grama[13].SetActive(true);
                 Grama[14].SetActive(true);
                 Grama[7].SetActive(false); 
                 Grama[3].SetActive(false);
                 Grama[6].SetActive(false); 


                break;
                                case "9":                                                 
                 Grama[9].SetActive(true);
                 Grama[16].SetActive(true);
                 Grama[17].SetActive(true);
                 Grama[4].SetActive(false);
                 Grama[10].SetActive(false);
                 Grama[5].SetActive(false); 
                 Grama[11].SetActive(false); 
                break;

                                case "10":
                 Grama[10].SetActive(true);
                 Grama[16].SetActive(true);
                 Grama[17].SetActive(true);
                 Grama[18].SetActive(true);
                 Grama[5].SetActive(false);
                 Grama[9].SetActive(false);
                 Grama[11].SetActive(false);
                break;

                                case "11":
                 Grama[11].SetActive(true);
                 Grama[17].SetActive(true);
                 Grama[19].SetActive(true);
                 Grama[18].SetActive(true);
                 Grama[2].SetActive(false);               
                 Grama[6].SetActive(false);
                 Grama[10].SetActive(false);    
                 Grama[12].SetActive(false);
                break;

                                case "12":
                 Grama[12].SetActive(true);
                 Grama[19].SetActive(true);
                 Grama[20].SetActive(true);
                 Grama[18].SetActive(true);
                 Grama[6].SetActive(false); 
                 Grama[10].SetActive(false); 
                 Grama[7].SetActive(false);
                 Grama[11].SetActive(false); 
                 Grama[13].SetActive(false);                  
                break;

                                case "13":
                 Grama[13].SetActive(true);
                 Grama[19].SetActive(true);
                 Grama[20].SetActive(true);
                 Grama[21].SetActive(true);
                 Grama[16].SetActive(false); 
                 Grama[7].SetActive(false);
                 Grama[8].SetActive(false);
                 Grama[11].SetActive(false);
                 Grama[12].SetActive(false); 
                 Grama[14].SetActive(false);
                break;

                                case "14":
                 Grama[14].SetActive(true);
                 Grama[22].SetActive(true);
                 Grama[20].SetActive(true);
                 Grama[21].SetActive(true);
                 Grama[13].SetActive(false);
                 Grama[15].SetActive(false);
                 Grama[12].SetActive(false); 
                 Grama[8].SetActive(false); 
                 break;

                                case "15":
                 Grama[15].SetActive(true);
                 Grama[22].SetActive(true);
                 Grama[21].SetActive(true);
                 Grama[14].SetActive(false);
                break;

                                case "16":
                 Grama[16].SetActive(true);
                 Grama[23].SetActive(true);
                 Grama[24].SetActive(true);
                 Grama[9].SetActive(false);
                 Grama[17].SetActive(false); 
                break;

                                case "17":
                 Grama[17].SetActive(true);
                 Grama[23].SetActive(true);
                 Grama[24].SetActive(true);
                 Grama[25].SetActive(true);
                 Grama[10].SetActive(false);
                 Grama[16].SetActive(false); 
                 Grama[18].SetActive(false);
                break;

                                case "18":
                 Grama[18].SetActive(true);
                 Grama[24].SetActive(true);
                 Grama[25].SetActive(true);
                 Grama[26].SetActive(true);
                 Grama[11].SetActive(false);
                 Grama[17].SetActive(false); 
                 Grama[19].SetActive(false); 
                 Grama[10].SetActive(false); 
                 Grama[16].SetActive(false); 

                break;

                                case "19":
                 Grama[19].SetActive(true);
                 Grama[25].SetActive(true);
                 Grama[26].SetActive(true);
                 Grama[27].SetActive(true);
                 Grama[12].SetActive(false);
                 Grama[18].SetActive(false); 
                 Grama[20].SetActive(false); 
                 Grama[11].SetActive(false);
                 Grama[17].SetActive(false); 

                 break;
                 
                                case "20":
                 Grama[20].SetActive(true);
                 Grama[26].SetActive(true);
                 Grama[27].SetActive(true);
                 Grama[28].SetActive(true);
                 Grama[12].SetActive(false); 
                 Grama[13].SetActive(false); 
                 Grama[18].SetActive(false);
                 Grama[19].SetActive(false); 
                 Grama[21].SetActive(false); 
                break;

                                case "21":
                 Grama[21].SetActive(true);
                 Grama[27].SetActive(true);
                 Grama[28].SetActive(true);
                 Grama[46].SetActive(false);
                 Grama[13].SetActive(false); 
                 Grama[19].SetActive(false); 
                 Grama[20].SetActive(false);
                 Grama[22].SetActive(false);
                break;

                                case "22":
                 Grama[22].SetActive(true);
                 Grama[23].SetActive(false); 
                 Grama[20].SetActive(false); 
                 Grama[14].SetActive(false); 
                 Grama[21].SetActive(false); 

                break;

                                case "23":
                 Grama[23].SetActive(true);
                 Grama[24].SetActive(true);
                 Grama[16].SetActive(false); 
                                break;

                                case "24":
                 Grama[24].SetActive(true);
                 Grama[29].SetActive(true);
                 Grama[17].SetActive(false); 
                 Grama[23].SetActive(false); 
                 Grama[25].SetActive(false); 
                 Grama[18].SetActive(false); 
                 Grama[26].SetActive(false); 

                 break;

                                case "25":
                 Grama[25].SetActive(true);
                 Grama[29].SetActive(true);
                 Grama[30].SetActive(true);
                 Grama[31].SetActive(true);
                 Grama[18].SetActive(false); 
                 Grama[24].SetActive(false); 
                 Grama[26].SetActive(false);
                 Grama[19].SetActive(false); 
                 Grama[27].SetActive(false); 

                break;

                                case "26":
                 Grama[26].SetActive(true);
                 Grama[30].SetActive(true);
                 Grama[31].SetActive(true);
                 Grama[32].SetActive(true);
                 Grama[19].SetActive(false); 
                 Grama[25].SetActive(false); 
                 Grama[27].SetActive(false); 
                 Grama[24].SetActive(false); 
                 Grama[18].SetActive(false); 

                break;
                
                                case "27":
                 Grama[27].SetActive(true);
                 Grama[31].SetActive(true);
                 Grama[32].SetActive(true);
                 Grama[20].SetActive(false); 
                 Grama[26].SetActive(false); 
                 Grama[28].SetActive(false); 
                break;

                                case "28":
                 Grama[28].SetActive(true);
                 Grama[32].SetActive(true);
                 Grama[21].SetActive(false); 
                 Grama[27].SetActive(false);
                 Grama[22].SetActive(false); 
                 Grama[20].SetActive(false); 
                 Grama[26].SetActive(false); 
                break;

                                case "29":
                 Grama[29].SetActive(true);
                 Grama[30].SetActive(true);
                 Grama[24].SetActive(false); 
                 break;

                                case "30":
                 Grama[30].SetActive(true);
                 Grama[31].SetActive(true);
                 Grama[16].SetActive(false); 
                 Grama[25].SetActive(false); 
                 Grama[29].SetActive(false);                   
                break;

                                case "31":
                 Grama[31].SetActive(true);
                 Grama[33].SetActive(true); 
                 Grama[26].SetActive(false); 
                 Grama[32].SetActive(false); 
                 Grama[30].SetActive(false); 
                break;

                                case "32": 
                 Grama[33].SetActive(true);
                 Grama[27].SetActive(false); 
                 Grama[26].SetActive(false);
                 Grama[30].SetActive(false);
                 Grama[31].SetActive(false); 


                break;

                                case "33": 
                 Grama[33].SetActive(true); 
                 Grama[31].SetActive(false);
                 Grama[32].SetActive(false); 

                                 // A PREENCHER
                break;
                }

    }
}



