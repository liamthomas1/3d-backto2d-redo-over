using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    public CharacterController Controller;
    public float speed = 10f;
    public float turnsmoothtime = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
           Cursor.lockState = CursorLockMode.Locked;
    }
	private void FixedUpdate()
	{
        MovementTime();
	}

	// Update is called once per frame
	void Update()
    {
        
    }

    void MovementTime() //tanks time  //https://www.youtube.com/watch?v=4HpC--2iowE&t=1128s
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(x, 0f, y).normalized;
        if(direction.magnitude > 0.1f)
		{
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            Controller.Move(direction * speed * Time.deltaTime);
		}
       
        
	}
}
