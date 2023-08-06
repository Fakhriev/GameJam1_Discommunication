using UnityEngine;

public class MovableObject : MonoBehaviour
{
    [SerializeField] private float distance = 2f;
    [SerializeField] private float speed = 2f;
    private bool isForward = true;
    private Vector3 startPosition;

    private void Awake()
    {
        startPosition = transform.position; 
    }
    private void Update()
    {
        if (isForward)
        {
            if(transform.position.z < startPosition.z + distance)
                transform.position += Vector3.forward * Time.deltaTime * speed;
            else
                isForward = false;
        }
        else
        {
            if(transform.position.z > startPosition.z - distance)
                transform.position -= Vector3.forward * Time.deltaTime * speed;
            else
                isForward = true;
        }
    }

}
