using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeenHit : MonoBehaviour
{
    public AudioSource beenHit;
    void Start()
    {
        PlayerPrefs.SetFloat("PlayerRed_HP", 100);
        PlayerPrefs.SetFloat("PlayerRed_EP", 100);
        PlayerPrefs.SetFloat("PlayerBlue_HP", 100);
        PlayerPrefs.SetFloat("PlayerBlue_EP", 100);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.transform.parent.parent.name == "RED_Player@Sumo High Pull" && (Input.GetMouseButton(0)|| Input.GetMouseButton(1)))
        {
            PlayerPrefs.SetFloat("PlayerRed_HP", PlayerPrefs.GetFloat("PlayerRed_HP") - 20);
            if (!beenHit.isPlaying)
            {
                beenHit.Play();
            }
            if (other.name == "mixamorig: Head")
            {
                PlayerPrefs.SetFloat("PlayerRed_HP", PlayerPrefs.GetFloat("PlayerRed_HP") - 20);
                if (!beenHit.isPlaying)
                {
                    beenHit.Play();
                }
            }
        }
        Debug.Log(PlayerPrefs.GetFloat("PlayerRed_HP"));


        if (other.transform.parent.parent.name == "BLUE_Player@Sumo High Pull" && (Input.GetMouseButton(0) || Input.GetMouseButton(1)))
        {
            PlayerPrefs.SetFloat("PlayerBlue_HP", PlayerPrefs.GetFloat("PlayerBlue_HP") - 20);
            if (!beenHit.isPlaying)
            {
                beenHit.Play();
            }

            if (other.name == "mixamorig: Head")
            {
                PlayerPrefs.SetFloat("PlayerBlue_HP", PlayerPrefs.GetFloat("PlayerBlue_HP") - 20);
                if (!beenHit.isPlaying)
                {
                    beenHit.Play();
                }
            }
        }
        Debug.Log(PlayerPrefs.GetFloat("PlayerBlue_HP"));
    }
}
