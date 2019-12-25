using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShine : MonoBehaviour
{

    public Button button;
    void Start()
    {
        ColorBlock cb = new ColorBlock();
        cb.normalColor = Color.red;
        cb.highlightedColor = Color.green;
        cb.pressedColor = Color.blue;
        cb.disabledColor = Color.black;
        button.colors = cb;
    }
}
