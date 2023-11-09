using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace HeroicArcade.CC.Core
{
    [System.Serializable] public class MoveInputEvent : UnityEvent<Vector2> { }
    [System.Serializable] public class CameraRecenterXEvent : UnityEvent<bool> { }

    public sealed class InputController : MonoBehaviour
    {
        [SerializeField] MoveInputEvent moveInputEvent;
        [SerializeField] CameraRecenterXEvent cameraRecenterXEvent;

        Controls controls;
        private void Awake()
        {
            controls = new Controls();

            controls.Gameplay.Move.started += OnMove;
            controls.Gameplay.Move.performed += OnMove;
            controls.Gameplay.Move.canceled += OnMove;

            controls.Gameplay.Jump.started += OnJump;
            controls.Gameplay.Jump.canceled += OnJump;

            controls.Gameplay.CameraRecenterX.started += OnRecenterX;
            controls.Gameplay.CameraRecenterX.canceled += OnRecenterX;

            controls.Gameplay.Sprint.started += OnSprint; //Added
            controls.Gameplay.Sprint.canceled += OnSprint; //Added
        }

        private Vector2 moveInput;
        [HideInInspector] public bool IsMovePressed;
        private void OnMove(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
            moveInputEvent.Invoke(moveInput);
        }

        [HideInInspector] public bool IsJumpPressed;
        private void OnJump(InputAction.CallbackContext context)
        {
            IsJumpPressed = context.ReadValueAsButton();
        }

        [HideInInspector] public bool IsSprintPressed; //added
        private void OnSprint(InputAction.CallbackContext context) //added
        {
            IsSprintPressed = context.ReadValueAsButton();
        }                                                           //added

        private void OnEnable()
        {
            controls.Gameplay.Enable();
        }

        private void OnDisable()
        {
            controls.Gameplay.Disable();
        }
        private void OnRecenterX(InputAction.CallbackContext context)
        {
            cameraRecenterXEvent.Invoke(context.ReadValueAsButton());
        }
    }
}
