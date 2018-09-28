using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour {
    public bool ifbool;
    public int userValue;
    public int diceStartValue = 10;
    public int dragonLife;
    public int playerLife;
    public int playerDamage;
    public int dragonDamage;
    public int dragonHitChance;
    public int playerMinDamage;
    public int playerMaxDamage;
    public int HiLo;
    public int old = 50;
    public int score;
    public int highscore;

    void Start() {
        if (Random.Range(10, 101) <= 10)
        {
            Debug.Log(string.Format("The dragon is twice as strong {0}", dragonLife = dragonLife + Random.Range(200, 301)));
        }
        else
        {
            dragonLife += Random.Range(100, 151);
            playerMinDamage = Random.Range(5, 11);
            playerMaxDamage = Random.Range(20, 31);
        }
    }

    // Update is called once per frame
    void Update() {
        // Uppgift 1
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        // Uppgift 2
        if (Input.GetKeyDown(KeyCode.R))
        {
            print(diceStartValue += Random.Range(1, 25));
            print(diceStartValue -= Random.Range(1, 25));
            if(diceStartValue >= 20)
            {
                print("Vinst");
            }
            else if(diceStartValue <= 0)
            {
                print("Förlust");
            }
        }

        // Uppgift 3,4
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Random.Range(5,101) <= 5)
            {
                Debug.Log(string.Format("Critical hit {0}", dragonLife = dragonLife - 300) + " dragon hp left");
            }
            if (Random.Range(1, 3) == 1)
            {
                Debug.Log(string.Format("Min Damage, Dragon HP: {0}", dragonLife = dragonLife - playerMinDamage));
            }
            else
            {
                Debug.Log(string.Format("Max Damage, Dragon HP: {0}", dragonLife = dragonLife - playerMaxDamage));
            }
            dragonHitChance = Random.Range(1, 3);
            if (dragonHitChance == 1)
            {
                print("Dragon attack missed");
            }
            else if (dragonHitChance == 2)
            {
                Debug.Log(string.Format("Player HP: {0}", (playerLife = playerLife - (dragonDamage = Random.Range(10, 21)))));
            }
        }

        //Uppgift 5
        if(Input.GetKeyDown(KeyCode.Y))
        {
            HiLo = Random.Range(0, 100);
            if(HiLo > old)
            {
                Debug.Log(string.Format("Correct, Rolled: {0}", HiLo));
                Debug.Log(string.Format("Score: {0}", score += 1));
                old = HiLo;
            }
            else
            {
                Debug.Log(string.Format("Wrong, Rolled: {0}", HiLo));
                Debug.Log(string.Format("Score: {0}", score));
                if(score > highscore)
                {
                    highscore = score;
                }
                score = 0;
                old = 50;
                print("Game over");
                Debug.Log(string.Format("highscore: {0}", highscore));
            }
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            HiLo = Random.Range(0, 100);
            if(HiLo < old)
            {
                Debug.Log(string.Format("Correct, Rolled: {0}", HiLo));
                Debug.Log(string.Format("Score: {0}", score += 1));
                old = HiLo;
            }
            else
            {
                Debug.Log(string.Format("Wrong: Rolled: {0}", HiLo));
                Debug.Log(string.Format("Score: {0}", score));
                if(score > highscore)
                {
                    highscore = score;
                }
                score = 0;
                old = 50;
                print("Game over");
                Debug.Log(string.Format("highscore: {0}", highscore));
            }

            
        }


        // != inte lika med
        // == lika med
        // > Större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med
        // && och
        // || eller (alt gr + <)

        //if (value == 3)
        //{
        //    print("nice");
        //}
        //else if (value == 2 && ifbool == true)
        //{
        //    print("ok");
        //}
        //else
        //{
        //    print("jaha");
        //}

    }
}
