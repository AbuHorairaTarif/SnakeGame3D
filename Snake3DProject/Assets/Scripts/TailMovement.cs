using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour {

	public float Speed;

	//public List <GameObject> tailTarget =new List<GameObject>();
	public Vector3 tailTarget;
	public int indx;
	public GameObject tailTargetObj;
	public SnakeMovement mainSnake;
	// Use this for initialization
	void Start()
	{
		mainSnake = GameObject.FindGameObjectWithTag ("SnakeMain").GetComponent<SnakeMovement>();
		Speed = mainSnake.Speed+1.5f;
		tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count-2];
		indx = mainSnake.tailObjects.IndexOf (gameObject);
	}


	// Update is called once per frame
	void Update () {
		tailTarget = tailTargetObj.transform.position;
		transform.LookAt (tailTarget);
		transform.position = Vector3.Lerp (transform.position, tailTarget, Time.deltaTime * Speed);
		
	}
/*
     public float delayTime = 5f;
 
    int notes = 0;
 
    void OnTriggerEnter(Collider other){
        if(notes == 3){
            Invoke("DelayedAction", delayTime);
        }
    }
    
    void DelayedAction(){
        SceneManager.LoadScene("Level");
    }
  */  
    
	void OnTriggerEnter(Collider other)
	{
        
		if (other.CompareTag ("SnakeMain")) 
		{
			if (indx>2) 
			{
                //Scene scene = SceneManager.GetActiveScene();
                
                
				SceneManager.LoadScene("Level");
			}
		}
	}

}
