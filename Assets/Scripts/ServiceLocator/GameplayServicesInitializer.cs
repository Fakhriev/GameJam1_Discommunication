using UnityEngine;

public class GameplayServicesInitializer : MonoBehaviour
{
    [SerializeField] private Player player;

    private void Awake()
    {
        ServiceLocator.Initialize();
        ServiceLocator.Current.Register(player);
    }
}