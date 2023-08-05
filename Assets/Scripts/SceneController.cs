using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private int currentSceneIndex;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void OnBeforeSceneLoadRuntimeMethod()
    {
        SceneManager.LoadScene(0);
        Cursor.visible = true;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}