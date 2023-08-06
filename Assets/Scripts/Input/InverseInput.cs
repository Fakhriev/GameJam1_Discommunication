using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InverseInput : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private PlayerInput _playerInput;

    private Dictionary<InputMapState, string> _nameByStates = new Dictionary<InputMapState, string>
    {
        {InputMapState.Normal , "Player" },
        {InputMapState.Inverse , "InversePlayer" },
        {InputMapState.NoInput , "NoInput" },

    };

    private void OnInputChanged(InputMapState newState)
    {
        _playerInput.SwitchCurrentActionMap(_nameByStates[newState]);
        _player.SetCopOnHeadActiveState(newState == InputMapState.Inverse);
    }

    private void OnEnable()
    {
        InverseInputTrigger.InputMapChanged += OnInputChanged;
        FinishTrigger.InputMapChanged += OnInputChanged;
    }

    private void OnDisable()
    {
        InverseInputTrigger.InputMapChanged -= OnInputChanged;
        FinishTrigger.InputMapChanged -= OnInputChanged;
    }
}

public enum InputMapState
{
    Normal,
    Inverse, 
    NoInput
}
