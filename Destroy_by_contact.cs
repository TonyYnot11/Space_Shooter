using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_by_contact : MonoBehaviour
{
    public GameObject Player_Explosion;
    public GameObject Explosion;
    public int ScoreValue ;
    private Game_Controller gameController;
    private Game_Pause gamePause;
    


    void Start()
    {
        

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Game_Controller>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(Explosion, transform.position, transform.rotation);
        if(other.tag == "Player")
        {
           
                Instantiate(Player_Explosion, other.transform.position, other.transform.rotation);
                ScoreValue = 0;
            
      
        }
        gameController.Add_Score(ScoreValue);
        
        
        Destroy(other.gameObject);
        
        Destroy(gameObject);
        
        
    }
}
