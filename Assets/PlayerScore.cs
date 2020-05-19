using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private int errors;
    public Text errorsText;
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        errors = 3;
        score = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: S'occuper de la décrément du score + errors
    private void SetCountText()
    {
        scoreText.text = "Score : " + score;
        errorsText.text = "Errors : " + errors;
        if (errors <= 0)
        {
            scoreText.text = "YOU LOSE.";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cylinder"))
        {
            score += 1;
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            score -= 1;
            errors -= 1;
        }
        SetCountText();
    }
}
