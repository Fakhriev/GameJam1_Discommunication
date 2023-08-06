using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Source.Finish
{
    public class Finish : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        private void OnEnable()
        {
            FinishTrigger.LevelFinished += OnLevelFinished;
        }
        private void OnDisable()
        {
            FinishTrigger.LevelFinished -= OnLevelFinished;
        }

        private void OnLevelFinished(PlayerHibox playerHibox)
        {
            playerHibox.Player.SetPosition(_player.transform.position, Quaternion.Euler(0,90,0));
            _player.GetComponent<Animator>().SetTrigger("FinishTrigger");
        }

    }
}
