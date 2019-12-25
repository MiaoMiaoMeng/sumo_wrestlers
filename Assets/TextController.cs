using UnityEngine;
using System.Collections;

public class TextController : MonoBehaviour
{
    public float speed;
    void Update()
    {
        if (speed != 0)
        {
            float y = GetComponent<RectTransform>().anchoredPosition.y + speed * Time.deltaTime;
            GetComponent<RectTransform>().anchoredPosition = new Vector3(232, y, 0);
        }
    }
}
//其实从六月
//份到现在我真的一直
//在努力，想做到言出
//必行真的还是满困难
//的。但是我真的有在
//努力，上个假期找实习