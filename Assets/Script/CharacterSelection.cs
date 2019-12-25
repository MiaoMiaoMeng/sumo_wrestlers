using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
	private GameObject[] characterList;
	private int index;
	private void Start()
	{
        PlayerPrefs.SetString("winer","player");
        PlayerPrefs.SetInt("player", 0);
        characterList = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
		{
			characterList[i] = transform.GetChild(i).gameObject;
		}
		foreach (GameObject go in characterList)
			go.SetActive(false);
		if (characterList[0])
			characterList[0].SetActive(true);
	}

	public void ToggleLeft()
	{
		characterList[index].SetActive(false);
		index--;
		if (index < 0)
			index = characterList.Length - 1;
		characterList[index].SetActive(true);
        PlayerPrefs.SetInt("player",index);
        //Debug.Log(PlayerPrefs.GetInt("player"));
    }

	public void ToggleRight()
	{
		characterList[index].SetActive(false);
		index++;
		if (index == characterList.Length)
			index = 0;
		characterList[index].SetActive(true);
        PlayerPrefs.SetInt("player",index);
        //Debug.Log(PlayerPrefs.GetInt("player"));
    }

	public void SelcetButton() {
		SceneManager.LoadScene("Map");

	}

	public void Update() {
		if (Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.A))
		{
			ToggleLeft();
		}
		if (Input.GetKeyUp(KeyCode.RightArrow)|| Input.GetKeyUp(KeyCode.D))
		{
			ToggleRight();
		}

	}
}
