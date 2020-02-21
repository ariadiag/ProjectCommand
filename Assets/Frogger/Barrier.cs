using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrier : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player"){
			Debug.Log("You lose!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		} else {
			Destroy(col.gameObject);
		}
	}
}
