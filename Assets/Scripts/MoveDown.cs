using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : CollisionTrigger
{
    [SerializeField] private float _prefabSpeed = 1f;
    [SerializeField] private float _downBorder = 0;

    protected override void OnPlayerCollided(PlayerHibox playerHibox)
    {
        playerHibox.Player.Die(Vector3.zero);
    }

    private void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * _prefabSpeed);

        if (transform.position.y < _downBorder)
        {
            Destroy(gameObject);
        }
    }
}
