using StarterAssets;
using UnityEngine;

public class Player : MonoBehaviour, IService
{
    [SerializeField] private RagdollActivator ragdollActivator;
    [SerializeField] private PlayerHibox playerHibox;
    [SerializeField] private ThirdPersonController thirdPersonController;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Rigidbody pushRb;
    [SerializeField] private GameObject copOnHead;

    [SerializeField] private GameObject[] boxes;
    [SerializeField] private GameObject[] stones;

    private float _defaultMoveSpeed;
    private float _defaultSprintSpeed;
    private float _defaultJumpHieght;

    public void Die(Vector3 pushDirection)
    {
        playerHibox.Deactivate();
        ragdollActivator.ActivateRagdoll(pushDirection);
    }

    public void Push(Vector3 pushDirection)
    {
        characterController.enabled = false;
        pushRb.AddForce(pushDirection, ForceMode.Impulse);
        characterController.enabled = true;
    }

    public void Forced(float force)
    {
        thirdPersonController.ForceJump(force);
    }

    public void SetPosition(Vector3 position)
    {
        characterController.enabled = false;
        transform.position = position;
        characterController.enabled = true;
    }

    public void SetCopOnHeadActiveState(bool value)
    {
        copOnHead.SetActive(value);
    }

    public void Slow(float slowMultiplyier)
    {
        _defaultMoveSpeed = thirdPersonController.MoveSpeed;
        _defaultSprintSpeed = thirdPersonController.SprintSpeed;
        _defaultJumpHieght = thirdPersonController.JumpHeight;

        thirdPersonController.MoveSpeed *= slowMultiplyier;
        thirdPersonController.SprintSpeed *= slowMultiplyier;
        thirdPersonController.JumpHeight *= slowMultiplyier;

        foreach(var box in boxes)
        {
            box.gameObject.SetActive(true);
        }
    }

    public void NormalizeSpeed()
    {
        thirdPersonController.MoveSpeed = _defaultMoveSpeed;
        thirdPersonController.SprintSpeed = _defaultSprintSpeed;
        thirdPersonController.JumpHeight = _defaultJumpHieght;

        foreach (var box in boxes)
        {
            box.gameObject.SetActive(false);
        }
    }

    public void ActivateStones()
    {
        foreach (var stone in stones)
        {
            stone.gameObject.SetActive(stone);
        }
    }
}