using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunktionerOchVaribler : MonoBehaviour
{
    public string Mening1;
    public string Mening2;
    public string Mening3;
    public int A;
    public int B;
    public int triangleBase;
    public float angle;
    public string Username;
    public int radius;
    public int Damage;
    public int Life;
    public int Demons;
    public int minDamage;
    public int maxDamage;
    public float count = 5;
    public float countMulti = 10;
    float playerMaxLife = 1000;
    float playerResist = 0.2f;
    float enemyDamage = 100;
    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
        Uppgift8();
        Uppgift10();
        Uppgift11();
    }
    void Uppgift1()
    {
        //Debug.Log(963 * 421 - 175463 / 87f);
        Debug.Log(string.Format("Uppgift 1: {0}", 963 * 421 - 175463 / 87f));
    }
    void Uppgift2()
    {
        Debug.Log(Mening1);
        Debug.Log(Mening2);
        Debug.Log(Mening3);
    }
    void Uppgift3()
    {
        Debug.Log(string.Format("Uppgift 3: {0}", Mathf.Pow(A, B)));
        Debug.Log(string.Format("Uppgift 3: {0}", Mathf.Sqrt(A)));
    }
    void Uppgift4()
    {
        Debug.Log(string.Format("Uppgift 4: {0}", (triangleBase * 8 / 2)));
    }
    void Uppgift5()
    {
        Debug.Log(string.Format("Uppgift 5: {0}", (360.0 / angle)));
    }
    void Uppgift6()
    {
        Debug.Log(string.Format("Uppgift 6: {0}", ("Admin " + Username + " of the server")));
    }
    void Uppgift7()
    {
        Debug.Log(string.Format("Uppgift 7: {0}", (4 * Mathf.PI * Mathf.Pow(radius, 3) / 3 * 2978)));
    }
    void Uppgift8()
    {
        Debug.Log(string.Format("Uppgift 8: {0}", (890000 / Damage)));
        Debug.Log(string.Format("Uppgift 8a: {0}", (Life / Damage)));
        Debug.Log(string.Format("Uppgift8 8b: {0}", (Life * Demons / Damage)));
        Debug.Log(string.Format("Uppgift8 8c, minDamage: {0}", (Life / minDamage)));
        Debug.Log(string.Format("Uppgift8 8c, maxDamage: {0}", (Life / maxDamage)));
        Debug.Log(string.Format("Uppgift8 8c, medelvärde : {0}", (890 + 445) / 2));
    }
    void Uppgift10()
    {
        Debug.Log(string.Format("Uppgift 11: {0}", (countMulti * 3 / 2)));
    }
    void Uppgift11()
    {
        Debug.Log(string.Format("Uppgift 11: {0}", (playerMaxLife - playerResist * enemyDamage)));
    }


    // Update is called once per frame
    void Update()
    {
        //Uppgift 9:
        Debug.Log(string.Format("Uppgift 9: {0}", (count = count * count)));

    }
}
