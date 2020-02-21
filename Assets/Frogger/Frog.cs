using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
	public Rigidbody2D rb;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)){
			rb.MovePosition(rb.position + Vector2.right);
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)){
			rb.MovePosition(rb.position - Vector2.right);
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)){
			rb.MovePosition(rb.position + Vector2.up);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)){
			rb.MovePosition(rb.position - Vector2.up);
		}
    }
	
	void OnTriggerEnter2D (Collider2D col){
		if (col.tag =="car"){
			Debug.Log("We LOST!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
