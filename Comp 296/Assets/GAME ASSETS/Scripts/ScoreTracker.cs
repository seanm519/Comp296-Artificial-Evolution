using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{

    //public  float  score = 0;
    //public  Text scoreText;
    public TextMeshProUGUI ScoreTextMesh;
    public string temp;
    
    

    public void Start()
    {

        

        if (SceneManager.GetActiveScene().name == "Level01")
        {
            ScoreHolder.Score = 0;
        }

        ScoreTextMesh = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        
        scoreUpdate(0);
        
    }

    

    

    public void scoreUpdate(float scoreValue)
    {
        ScoreHolder.Score += scoreValue;
        Debug.Log("adding score of " + scoreValue + ", score is now " + ScoreHolder.Score);
       // scoreText.text = score.ToString("0" + " Points");
        ScoreTextMesh.text = ScoreHolder.Score.ToString("0" + " Points");
    }

    
}
