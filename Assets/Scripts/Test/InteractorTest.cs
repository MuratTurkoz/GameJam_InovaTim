
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class InteractorTest : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionRadius;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private PlayerCharacterMoveTest _characterMoveTest;
    private Collider[] _colliders = new Collider[3];
    public Collider[] Colliders => _colliders;
    [SerializeField] private int _numFound = 0;
    private PlayerInputTest _playerInputTest;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        _playerInputTest = GetComponent<PlayerInputTest>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(PlayerCharacterMoveTest.IsMoving);
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionRadius, _colliders, _layerMask);
        if (_numFound > 0)
        {
            if (_colliders[0].gameObject.CompareTag("Build"))
            {
                Debug.Log("Hi");
                //_colliders[0].GetComponentInParent<AITest>().Position = transform.position;
            }
            else if (_colliders[0].gameObject.CompareTag("Source"))
            {
                    PlayerCharacterMoveTest.IsMoving = false;
                //if (GameManager.isBuz==false)
                //{
                //    //_colliders[0].GetComponent<SourceCard>().OpenCard();
                //}
             
                //Debug.Log("Electrat Geldi");
            }
            else
            {
                //animator.SetBool("IsAttack", false);
            }
            if (_colliders.Length<0)
            {

            }

     

            //Debug.Log(_colliders.Length);

            PlayerCharacterMoveTest.IsMoving = false;


        }
        else
        {
            //_colliders[0].GetComponent<SourceCard>().CloseCard();
            //animator.SetBool("IsAttack", false);

        }

    }
    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.yellow;
    //    Gizmos.DrawSphere(_interactionPoint.position, _interactionRadius);
    //    Gizmos.DrawCube(Vector3.zero,Vector3.up);
    //}
}
