using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM_PackMan : MonoBehaviour
{
    public Text Score;
    public Text Lives;

    public int score { get; private set; }
    public int lives { get; private set; }


    void Start()
    {
        newGame();
    }

    // Update is called once per frame
    void Update()
    {
        Setscore(score + 1);
        if (Input.GetKeyDown("space"))
        {
            Setlives(lives - 1);
        }
    }

    private void newGame()
    {
        Setscore(0);
        Setlives(3);
    }

    private void Setlives(int lives)
    {
        this.lives = lives;
        Lives.text = "!" + Lives.ToString();
    }

    private void Setscore(int score)
    {
        this.score = score;
        Score.text = score.ToString().PadLeft(2, '0'); 
    }

    public void pelleteaten(Pellet pellet)
    {
        pellet.gameObject.SetActive(false);

        Setscore(score + pellet.points);
    }

    public void super_pelleteaten(Super_Pellet pellet)
    {
        pellet.gameObject.SetActive(false);

        Setscore(score + pellet.points);
    }
}
