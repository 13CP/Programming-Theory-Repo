using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    // ABSTRACTION
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}


