using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonShine : MonoBehaviour
{
    public Color HintColor;//自己定义一个想要的颜色，默认是黑色
    void Update()
    {
        HintColor.a = Mathf.PingPong(1 * Time.time, 1F);//5*Time.time是闪烁频率，大家可以自己改，1F就是颜色的a的最大的值，意思就是从完全透明到完全不透明
        GetComponent<Image>().color = HintColor;//获取UI的image组件的颜色并把上面变化的hintcolor赋值给他
    }

}
