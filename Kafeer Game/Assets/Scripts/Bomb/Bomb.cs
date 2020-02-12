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
    public GameObject Grass;
    public GameObject BuildingSpawner;
    public int score;
    public Text scoreText;
    public GameObject GameWinBoard;
    public bool gameWin;
    public bool gameLost;
    public GameObject GameWinStarAwesome, GameWinStarHighSmile, GameWinStarNormalSmile;

    void Start()
    {
        gameLost = false;
        gameWin = false;
        score = 0;
        numberOFBullet = 20;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

        if (gameLost)
        {
            ActiveAndDeactivateCallForLost();
        }

        if (gameWin)
        {
            ActiveAndDeactiveCallForWin();
        }
        setScore();
        GameWin();
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
        if (numberOFBullet == 0)
        {
            gameLost = true;
            
        }
    }


    

    private void setScore()
    {
        scoreText.text = score.ToString();
    }

    private void GameWin()
    {

        if (score >= 300)
        {
            if (numberOFBullet >= 10)
            {
                GameWinStarAwesome.SetActive(true);
                gameWin = true;
            }
            else if (numberOFBullet >= 8)
            {
                GameWinStarHighSmile.SetActive(true);
                gameWin = true;
            }else if (numberOFBullet >= 6)
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
        yield return new WaitForSeconds(0.2f);
        GameOverBoard.SetActive(true);
        GamePlayCanvas.SetActive(false);
        Kafeer.SetActive(false);
        Grass.SetActive(false);
        BuildingSpawner.SetActive(false);
    }
    IEnumerator ActiveAndDeactiveForWin()
    {
        yield return new WaitForSeconds(0.2f);
        GameWinBoard.SetActive(true);
        GamePlayCanvas.SetActive(false);
        Kafeer.SetActive(false);
        Grass.SetActive(false);
        BuildingSpawner.SetActive(false);
    }
}
