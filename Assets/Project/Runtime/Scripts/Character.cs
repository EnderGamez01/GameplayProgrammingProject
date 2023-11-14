using MenteBacata.ScivoloCharacterController;
using UnityEngine;

namespace HeroicArcade.CC.Core
{
    public class Character : MonoBehaviour
    {
        [SerializeField] InputController inputController;
        public InputController InputController { get => inputController; }

        [SerializeField] Animator animator;
        public Animator Animator { get => animator; }

        [HideInInspector] public float CurrentMaxMoveSpeed;
        [HideInInspector] public Vector3 velocity = Vector3.zero;
        [HideInInspector] public float velocityXZ = 0f;
        [HideInInspector] public MoveContact[] moveContacts = CharacterMover.NewMoveContactArray;
        [HideInInspector] public int contactCount;

        public enum CameraStyle
        {
            Adventure,
            Combat,
            EricWei,
        }
        [Header("Character Parameters")]
        [SerializeField] CameraStyle camStyle;
        public CameraStyle CamStyle { get => camStyle; set => camStyle = value; }
        [SerializeField] float maxWalkSpeed; //6
        [SerializeField] float maxSprintSpeed;   //added
        public float CurrentMaxWalkSpeed { get => maxWalkSpeed; set => maxWalkSpeed = value; }
        public float CurrentMaxSprintSpeed { get => maxSprintSpeed; set => maxSprintSpeed = value; } //added
        //[SerializeField] float gravity;
        //public float Gravity { get => gravity; }
        [SerializeField] float turnSpeed;
        public float TurnSpeed { get => turnSpeed; }
        [SerializeField] float moveAcceleration;
        public float MoveAcceleration { get => moveAcceleration; set => moveAcceleration = value; }
        [SerializeField] CharacterMover mover;
        public CharacterMover Mover { get => mover; }
    }
}
