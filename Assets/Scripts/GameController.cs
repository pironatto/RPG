using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    private PlayerController _playerController;
    private ControleTabuleiro _controleTabuleiro;
    public GameObject Player;
    public string posPlayer;


    // Start is called before the first frame update
    void Start()
    {   
        _playerController = FindObjectOfType(typeof(PlayerController))as PlayerController;
        _controleTabuleiro = FindObjectOfType(typeof(ControleTabuleiro))as ControleTabuleiro;     

        // ACENDE O PRIMEIRO GRAMADO
       _controleTabuleiro.Grama[0].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {     
            //VERIFICAR A POSIÇÃO DO PERSONAGEM
            PosicaoPlayer();

            //MOSTRA QUAIS GRAMAS ESTÃO DISPONIVEIS AO CLICAR NO PERSONAGEM
            if(_playerController.clicar && _controleTabuleiro.selecionado == false){           
                    _controleTabuleiro.ControleGramaAcesa();
         }

            //PARA MOVIMENTAR O PERSONAGEM AO LOCAL
            if(_controleTabuleiro.clicar){                
                 if(_controleTabuleiro.selecionado){
                     _playerController.MovePlayer(); 
                      }  
            }

    }

    //VERIFICAR EM QUAL GRAMA O PERSONAGEM ESTÁ PISANDO
    void PosicaoPlayer(){
            posPlayer = _controleTabuleiro.posGrama;
            Debug.Log(posPlayer);
    }


}
