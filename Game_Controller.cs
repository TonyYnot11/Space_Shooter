using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 Spawn_Values;
    public int Hazard_Count;
    public float Spawn_Wait;
    public float Start_Wait;
    public float Wave_Wait;
    public UnityEngine.UI.Text ScoreText;
    public UnityEngine.UI.Text LivesText;
    public UnityEngine.UI.Text GameOverScoreText;
    private int score;
    private void Start()
    {
        //lives = 3;
        score = 0;
        Update_Score();
       StartCoroutine (SpawnWays());
    }


    private void Update()
    {
        
    }
    IEnumerator SpawnWays()
    {
        yield return new WaitForSeconds(Start_Wait);
        while (true)
        {
            for (int i = 0; i < Hazard_Count; i++)
            {

                Vector3 Spawn_Position = new Vector3(Random.Range(-Spawn_Values.x, Spawn_Values.x), Spawn_Values.y, Spawn_Values.z);
                Quaternion Spawn_Rotation = Quaternion.identity;
                Instantiate(hazard, Spawn_Position, Spawn_Rotation);
                yield return new WaitForSeconds(Spawn_Wait);
            }

            yield return new WaitForSeconds(Wave_Wait);
        }

        
        
    }

    public void Add_Score(int newScoreValue)
    {
        score += newScoreValue;
        Update_Score();
    }

    //public void Add_Lives(int newlives)
    //{
    //    lives += newlives;
    //    Update_Lives();
    //}


    void Update_Score()
    {
        ScoreText.text = "Score: " + score.ToString();
        GameOverScoreText.text = "Score: " + score.ToString();
    }


    
    //void Update_Lives()
    //{
    //    LivesText.text += lives.ToString();
    //}
}
