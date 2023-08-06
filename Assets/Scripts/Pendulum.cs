using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField][Range(0,5f)] private float speed = 1.5f;
    [SerializeField] private float limit = 80f;
    private void Update()
    {
        float angle = limit * Mathf.Sin(Time.time * speed);
        transform.localRotation = Quaternion.Euler(angle, 0,0);
    }
}
