﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }
}
