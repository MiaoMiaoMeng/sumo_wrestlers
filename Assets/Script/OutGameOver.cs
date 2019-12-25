using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutGameOver : MonoBehaviour
{
    public AudioSource ending;
    public float timer = 1.0f;
    private bool isOver = false;
    private bool isPlayed = false;
    void Start()
    {

    }

    void Update()
    {
        if (isOver == true)
        {
            if (!ending.isPlaying && isPlayed == false)
            {
                isPlayed = true;
                ending.Play();
            }

            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                SceneManager.LoadScene("Ending");
            }
        }
    }

    // 碰撞开始
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.parent.name == "RED_Player@Sumo High Pull")
        {
            Debug.Log("YesYesYes");
            PlayerPrefs.SetString("winer", "PlayerRed");
            isOver = true;
            
        }
        if (other.transform.parent.parent.name == "BLUE_Player@Sumo High Pull")
        {
            Debug.Log("YesYesYes");
            PlayerPrefs.SetString("winer", "PlayerBlue");
            isOver = true;
        }
        Debug.Log(PlayerPrefs.GetString("winer"));
    }
}
