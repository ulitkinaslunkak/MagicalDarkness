using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private const string GRIP = "Grip";
    private const string TRIGGER = "Trigger";
    [SerializeField] private Animator _animator;

    [SerializeField] private InputActionProperty _gripAction;
    [SerializeField] private InputActionProperty _activateAction;

    private void Update()
    {
        var gripValue = _gripAction.action.ReadValue<float>();
        var actionValue = _activateAction.action.ReadValue<float>();

        gripValue = gripValue < 0.5f ? 0.5f : gripValue;

        _animator.SetFloat(GRIP, gripValue);
        _animator.SetFloat(TRIGGER, actionValue);

    }
}


