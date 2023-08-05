using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InverseInput : MonoBehaviour
{
    [SerializeField] private PlayerInput _playersInput;
    private Dictionary<InputMapState, string> _nameByStates = new Dictionary<InputMapState, string>
    {
        {InputMapState.Normal , "Player" },
        {InputMapState.Inverse , "InversePlayer" },
    };

    private void OnInputChanged(InputMapState newState)
    {
        _playersInput.SwitchCurrentActionMap(_nameByStates[newState]);
    }

    private void OnEnable()
    {
        InverseInputTrigger.InputMapChanged += OnInputChanged;
    }

    private void OnDisable()
    {
        InverseInputTrigger.InputMapChanged -= OnInputChanged;
    }
}

public enum InputMapState
{
    Normal,
    Inverse
}
