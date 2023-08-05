using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private int currentSceneIndex;

    public void RestartScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}