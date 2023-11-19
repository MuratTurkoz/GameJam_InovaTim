
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : CharacterManager<Player>
{
    Player _player;
    [SerializeField] PlayerInputTest _inputTest;
    void Start()
    {
       
     
    }

    // Update is called once per frame
    void Update()
    {
        Moved(_player);
    }


}
