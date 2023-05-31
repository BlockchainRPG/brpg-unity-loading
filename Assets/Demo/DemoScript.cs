using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public void OnClick()
    {
        LoadingAnimation.instance.StartLoading();
    }
}
