using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed = 10f;
    [SerializeField] Vector2 _velocity = Vector2.zero;
    [SerializeField] Vector3 _targetPosition;
    [SerializeField] private Vector2 moveDirection;
    Rigidbody2D _rb;
    Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    // Update is called once per frame
        Vector3 targetPosition;
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.GetAxis("Mouse X"));
            Debug.Log(Input.GetAxis("Mouse Y"));
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(new Vector2(Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y")));

            if (Physics.Raycast(ray, out hit))
            {
                //isMoving = true;
                targetPosition = new Vector3(hit.point.x, 0, hit.point.z);
                Debug.Log(targetPosition);
            }




            //moveDirection = targetPosition - transform.position;
            //Debug.Log(moveDirection.magnitude);
            //Quaternion.LookRotation(moveDirection.normalized);
            // 0, sol fare butonunu temsil eder.
            //targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //targetPosition.z = 0; // 2D oyunlarda Z ekseni genellikle 0 olarakyarlanýr.
            MovePlayer(targetPosition);
        }

        //if (Input.GetMouseButtonDown(0)) a
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
        //    if (hit.collider != null)
        //    {
        //        Debug.Log(hit.point);
        //        _rb.velocity = Vector2.MoveTowards(_rb.velocity, hit.point, _speed);
        //    }
        //    // Ray, bir nesneyle kesiþti
        //    //MovePlayer(hit.point); // hit.point, kesiþme noktasýdýr
        //}
        //Debug.Log(hit.point);
        //_velocity = new(hit.point.x, hit.point.y);
        //_targetPosition.z = 0;
    }
    public float speed = 5f; // Oyuncunun hýzýný ayarlayabilirsiniz.

    void MovePlayer(Vector3 targetPos)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    //Debug.Log(_targetPosition);

}
