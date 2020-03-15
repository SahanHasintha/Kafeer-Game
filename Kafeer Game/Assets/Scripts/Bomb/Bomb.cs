using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public GameObject Missile;
    public GameObject Kafeer;
    float BombSpeedX;
    private int numberOFBullet;
    public Text Bullet;
    public GameObject GameOverBoard;
    public GameObject GamePlayCanvas;
    public GameObject Panel;
    public GameObject Grass;
    public GameObject BuildingSpawner, TankSpawner;
    public int score;
    public Text scoreText;
    public GameObject GameWinBoard;
    public bool gameWin;
    public bool gameLost;
    public GameObject GameWinStarAwesome, GameWinStarHighSmile, GameWinStarNormalSmile;
    public int scoreForGameWin, numberOfBullet;
    public int gameWinGreate, gameWinNormal, gameWinLow;
    public Text GameOverBScore;
    int highScore;

    void Start()
    {
        gameLost = false;
        gameWin = false;
        score = 0;
        numberOFBullet = numberOfBullet;
    }
   public void SpawnBomb()
    {
        Fire();
    }

    void Update()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }*/

        if (gameLost)
        {
            ActiveAndDeactivateCallForLost();
        }

        if (gameWin==true)
        {
            ActiveAndDeactiveCallForWin();
        }
        setScore();
        GameWin();
        GameOverBoardScore();
    }
    void Fire()
    {
        numberOFBullet--;
        BombSpeedX = Kafeer.GetComponent<Rigidbody2D>().velocity.x;
        InstantiateMissile();
        StartCoroutine("BulletText");
    }
    private void InstantiateMissile()
    {
        GameObject missile = Instantiate(Missile, transform.position, transform.rotation);
        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(BombSpeedX - 1f, rb.velocity.y);

    }


    IEnumerator BulletText() {
        yield return new WaitForSeconds(0.2f);
        Bullet.text = numberOFBullet.ToString();
        if (numberOFBullet <= 0)
        {
                yield return new WaitForSeconds(1f);
                gameLost = true;
            
        }
    }


    

    private void setScore()
    {
        scoreText.text = score.ToString();
    }

    private void GameWin()
    {

        if (score >= scoreForGameWin)
        {
            if (numberOFBullet >= gameWinGreate)
            {
                GameWinStarAwesome.SetActive(true);
                gameWin = true;
            }
            else if (numberOFBullet >= gameWinNormal)
            {
                GameWinStarHighSmile.SetActive(true);
                gameWin = true;
            }else if (numberOFBullet >= gameWinLow)
            {
                GameWinStarNormalSmile.SetActive(true);
                gameWin = true;
            }
            else
            {
                gameWin = true;
            }
        }
    }

    public void ActiveAndDeactivateCallForLost()
    {
        StartCoroutine(ActiveAndDeactiveForLost());
    }
    public void ActiveAndDeactiveCallForWin()
    {
        StartCoroutine(ActiveAndDeactiveForWin());
    }

    IEnumerator ActiveAndDeactiveForLost()
    {
        
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0;
        GameOverBoard.SetActive(true);
        GamePlayCanvas.SetActive(false);
        Grass.SetActive(false);
        Panel.SetActive(true);
        
    }
    IEnumerator ActiveAndDeactiveForWin()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0;
        GameWinBoard.SetActive(true);
        GamePlayCanvas.SetActive(false);
        Grass.SetActive(false);
        Panel.SetActive(true);
    }

    void GameOverBoardScore()
    {
        PlayerPrefs.SetInt("score", score);
        GameOverBScore.text = PlayerPrefs.GetInt("score").ToString();
        
    }

    
}
