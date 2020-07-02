using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviours : MonoBehaviour
{
    public void Resume()
    {
        GM.instance.UnPauseMenu();
    }

    public void Restart()
    {
        GM.instance.RestartGame();
    }

    public void Resign()
    {
        GM.instance.Done();
    }





}
