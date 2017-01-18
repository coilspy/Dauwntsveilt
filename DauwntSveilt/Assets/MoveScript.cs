using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
    public int Speed;
    private int temp;
    public float rotationDegrees;
    public Animator animator;
	// Use this for initialization
	void Start () {
        temp = Speed;
        if(rotationDegrees == 0)
        {
            rotationDegrees = Mathf.PI / 4;
        }
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = temp * 2;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = temp;
        }
    if(Input.GetKey(KeyCode.W))
        {
            this.transform.position -= transform.forward * Time.deltaTime * Speed;
            animator.SetTrigger("Move");
        }
    if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += transform.forward * Time.deltaTime * Speed;
            animator.SetTrigger("Move");
        }
    if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -rotationDegrees, 0));
            animator.SetTrigger("Move");
        }
    if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, rotationDegrees, 0));
            animator.SetTrigger("Move");
        }
    if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("NotMoving");
        }
    }
}
