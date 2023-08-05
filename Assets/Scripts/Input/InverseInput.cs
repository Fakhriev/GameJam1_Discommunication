using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InverseInput : MonoBehaviour
{

    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private InverseInputTrigger _trigger;
    private Dictionary<InputMapState, string> _nameByStates = new Dictionary<InputMapState, string>
    {
        {InputMapState.Normal , "Player" },
        {InputMapState.Inverse , "InversePlayer" },
    };

    private void OnInputChanged(InputMapState newState)
    {
        _playerInput.SwitchCurrentActionMap(_nameByStates[newState]);
    }

    private void OnEnable()
    {
        _trigger.InputMapChanged += OnInputChanged;
    }

    private void OnDisable()
    {
        _trigger.InputMapChanged -= OnInputChanged;
    }
}

public enum InputMapState
{
    Normal,
    Inverse
}
