using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour 
{
    public static GameControl instance;                                    
    public GameObject gameOvertext;
    public bool gameOver = false;                 
    public Text scoreText;
    private int score = 0;                                       
    public float scrollSpeed = -1.5f;


    void Awake(){
        
        if (instance == null){ 
            instance = this;
        }
        
        else if(instance != this){
            Destroy (gameObject);
        }
    }

    void Update(){
        
        if (gameOver && Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored(){
        
        if (gameOver){   
            return;
        }

        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied(){
        gameOvertext.SetActive (true);
        gameOver = true;
    }
}