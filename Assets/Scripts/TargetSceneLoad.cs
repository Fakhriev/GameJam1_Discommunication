using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetSceneLoad : MonoBehaviour
{
    [SerializeField] private int _index;

    public void Change(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("»√–¿ O ŒÕ◊≈Õ¿");
    }
}
