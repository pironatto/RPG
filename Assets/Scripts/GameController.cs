using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{


    private PlayerController _playerController;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {   
        _playerController = FindObjectOfType(typeof(PlayerController))as PlayerController;
               
    }

    // Update is called once per frame
    void Update()
    {     

    }


}
