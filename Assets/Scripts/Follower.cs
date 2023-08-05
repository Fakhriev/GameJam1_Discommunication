using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;
    [SerializeField] private ObserveAxises observeAxises;

    private Vector3 _offset;

    private void Start()
    {
        _offset = objectToFollow.position - transform.position;
    }

    private void LateUpdate()
    {
        Vector3 nextPosition = objectToFollow.position - _offset;

        nextPosition.x = observeAxises.observeX ? nextPosition.x : transform.position.x;
        nextPosition.y = observeAxises.observeY ? nextPosition.y : transform.position.y;
        nextPosition.z = observeAxises.observeZ ? nextPosition.z : transform.position.z;

        transform.position = nextPosition;
    }

    [System.Serializable]
    public class ObserveAxises
    {
        public bool observeX = true;
        public bool observeY = true;
        public bool observeZ = true;
    }
}