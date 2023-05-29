using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGame : MonoBehaviour
{
    public void LoadScene(int index) => SceneManager.LoadScene(index);

    public void Settings()
    {
        Debug.Log("Settings");
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene("Shop");
        }
    }
}
