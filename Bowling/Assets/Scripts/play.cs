using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public void playGame()
    {
        Time.timeScale = 1;
        transform.parent.gameObject.SetActive(false);
    }
}
