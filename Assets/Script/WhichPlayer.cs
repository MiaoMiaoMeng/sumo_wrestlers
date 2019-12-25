using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichPlayer : MonoBehaviour
{
    public Animator player1;
    public Animator player2;
    private int isPlayer1;
    void Start()
    {
        isPlayer1 = PlayerPrefs.GetInt("player");
        if (isPlayer1 == 1)
        {
            player1.GetComponent<PlayerMoves>().enabled = true;
        }
        else if (isPlayer1 == 0)
        {
            player2.GetComponent<PlayerMoves>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
