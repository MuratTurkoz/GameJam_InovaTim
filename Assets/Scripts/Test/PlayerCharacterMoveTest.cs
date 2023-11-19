using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCharacterMoveTest : MonoBehaviour
{
    private CharacterController controller;
    private AudioSource audioSource;
    [SerializeField] private AudioClip _clip;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    public float PlayerSpeed { get => playerSpeed; set { playerSpeed = value; } }
    [SerializeField] private PlayerInputTest _playerInputTest;
    private Camera mainCamera;

    public static bool IsMoving = true;
    public static bool IsInteractable = false;
    [SerializeField] private Vector3 targetPosition;
    [SerializeField] private Vector3 moveDirection;

    [SerializeField] private ParticleSystem[] _vfx;

    private void Start()
    {
        mainCamera = Camera.main;
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        //Debug.Log(IsInteractable);
        
        GetMouseLeftClick();
        GetMouseRightClick();
        CheckGrounded();
        //Move
        GetMoved();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //if (hit.collider.CompareTag("Source"))
        //Debug.Log("Hi");
    }

    private void GetMouseLeftClick()
    {
        if (_playerInputTest.GetMouseLeftClickValue()&&IsInteractable==false)
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(_playerInputTest.GetPointerPosition());

            if (Physics.Raycast(ray, out hit))
            {
                IsMoving = true;
                targetPosition = new Vector3(hit.point.x, 0, hit.point.z);
                //Debug.Log(hit.collider.name);
            }

        }
    }
    private void GetMouseRightClick()
    {
        if (_playerInputTest.GetMouseRightClickValue())
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(_playerInputTest.GetPointerPosition());

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Enemy")
                {
                    IsMoving = false;
                    targetPosition = new Vector3(hit.point.x, 0, hit.point.z);
                    moveDirection = targetPosition - transform.position;
                    Quaternion.LookRotation(moveDirection.normalized);
                }

            }
        }
    }
    private void GetMoved()
    {
        if (IsMoving==true && IsInteractable == false)
        {
            moveDirection = targetPosition - transform.position;
            Quaternion.LookRotation(moveDirection.normalized);

            if (moveDirection.magnitude < 0.2f)
            {
                IsMoving = false;
                moveDirection = Vector3.zero;
                return;
            }

            moveDirection = moveDirection.normalized * playerSpeed * Time.deltaTime;
            foreach (var item in _vfx)
            {
                item.Play();
            }
            audioSource.PlayOneShot(_clip);
            controller.Move(moveDirection);
            if (moveDirection != Vector3.zero)
            {
                gameObject.transform.forward = moveDirection;
            }
        }
        else
        {
            foreach (var item in _vfx)
            {
                item.Stop();
            }
        }
        


     

    }

    private void CheckGrounded()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
    }
}

