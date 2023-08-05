using UnityEngine;

public class InputObserver : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
            RestartScene();
    }

    private void RestartScene()
    {
        sceneController.RestartScene();
    }
}