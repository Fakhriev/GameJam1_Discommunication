using UnityEngine;

[System.Serializable]
public class RadgollComponent
{
    public Collider collider;
    public Rigidbody rigidbody;

    public RadgollComponent(Collider collider, Rigidbody rigidbody)
    {
        this.rigidbody = rigidbody;
        this.collider = collider;
    }

    public void Deactivate()
    {
        collider.enabled = false;
        rigidbody.isKinematic = true;
    }

    public void Activate()
    {
        collider.enabled = true;
        rigidbody.isKinematic = false;
        rigidbody.velocity = Vector3.zero;
    }
}