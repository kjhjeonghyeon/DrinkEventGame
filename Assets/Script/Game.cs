using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject G1;
    public GameObject G2;
    public GameObject G3;
    public GameObject G4;
    public GameObject G5;
    public GameObject G6;
    public GameObject G7;
    GameObject nowG;


    public GameObject coin;
    public GameObject coinChange;
    public Sprite i1;
    public Sprite i2;
    public Sprite i3;
    public Sprite i4;
    public Sprite i5;
    public Sprite i6;
    public Sprite i7;
    Sprite coinChangeNow;





    public GameObject FXPanal;
    public GameObject TLS;
    public GameObject TLF;
    public GameObject x;
    public GameObject o;
    GameObject nowTL;
    GameObject nowTLox;

    public GameObject inButton;
    public GameObject outButton;
    public GameObject setting;

    public TMP_InputField f2;
    public TMP_InputField f3;
    public TMP_InputField f4;
    public TMP_InputField f5;
    public TMP_InputField f6;
    public TMP_InputField f7;
    int p2 = 1;
    int p3 = 1;
    int p4 = 1;
    int p5 = 1;
    int p6 = 1;
    int p7 = 1;


    public TMP_Text Num2;
    public TMP_Text Num3;
    public TMP_Text Num4;
    public TMP_Text Num5;
    public TMP_Text Num6;
    public TMP_Text Num7;
    public TMP_FontAsset font;
    float a = 0;
    int now;
    void Start()
    {
        now = 0;
    }

    // Update is called once per frame
    void Update()
    {
        p2 = int.Parse(f2.text);
        p3 = int.Parse(f3.text);
        p4 = int.Parse(f4.text);
        p5 = int.Parse(f5.text);
        p6 = int.Parse(f6.text);
        p7 = int.Parse(f7.text);






        Num2.text =p2.ToString();
        Num3.text =p3.ToString();
        Num4.text =p4.ToString();
        Num5.text =p5.ToString();
        Num6.text =p6.ToString();
        Num7.text =p7.ToString();
        Num7.font = font;
        Num2.font = font;
        Num3.font = font;
        Num4.font = font;
        Num5.font = font;
        Num6.font = font;
        a -= Time.deltaTime;


        if (Input.GetKeyDown("p"))
        {

            if (now == 0)
                GameStart1();
            if (a < -5.8f)
            {
                if (now == 1)
                    GameStart2();
                else if (now == 2)
                    GameStart3();
                else if (now == 3)
                    GameStart4();
                else if (now == 4)
                    GameStart5();
                else if (now == 5)
                    GameStart6();
                else if (now == 6)
                    GameStart7();


                a = 0;
            }

        }



    }
    public void GameStart1()
    {
        
        int a2 = UnityEngine.Random.Range(1, 100);
        if (a2>1&&a2<p2)
        {
            G1.gameObject.SetActive(false);

            FXPanal.SetActive(true);
            TLS.SetActive(true);
            o.SetActive(true);

            nowG = G2;
            nowTL = TLS;
            nowTLox = o;
            now = 1;
            coinChangeNow = i2;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);



        }
        else
        {
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i1;
            TLF.SetActive(true);
            x.SetActive(true);

            nowG = G1;
            nowTL = TLF;
            nowTLox = x;
            now = 0; coinChangeNow = i1;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);
        }

    }
    public void GameStart2()
    {
        int a3 = UnityEngine.Random.Range(1, 100);
        if (a3 > 1 && a3 < p3)
        {
            G2.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i2;
            TLS.SetActive(true);
            o.SetActive(true);

            nowG = G3;
            nowTL = TLS;
            nowTLox = o;
            now = 2;
            coinChangeNow = i3;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i2;
            TLF.SetActive(true);
            x.SetActive(true);

            nowG = G1;
            nowTL = TLF;
            nowTLox = x;
            now = 0;
            coinChangeNow = i1;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }

    }
    public void GameStart3()
    {
        int a4 = UnityEngine.Random.Range(1, 100);
        if (a4 > 1 && a4 < p4)
        {
            G3.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i3;
            TLS.SetActive(true);
            o.SetActive(true);

            nowG = G4;
            nowTL = TLS;
            nowTLox = o;
            now = 3;
            coinChangeNow = i4;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i3;
            TLF.SetActive(true);
            x.SetActive(true);

            nowG = G1;
            nowTL = TLF;
            nowTLox = x;
            now = 0; coinChangeNow = i1;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }

    }
    public void GameStart4()
    {
        int a5 = UnityEngine.Random.Range(1, 100);
        if (a5 > 1 && a5 < p5)
        {
            G4.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i4;
            TLS.SetActive(true);
            o.SetActive(true);

            nowG = G5;
            nowTL = TLS;
            nowTLox = o;
            now = 4;
            coinChangeNow = i5;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i4;
            TLF.SetActive(true);
            x.SetActive(true);

            nowG = G1;
            nowTL = TLF;
            nowTLox = x;
            now = 0; coinChangeNow = i1;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }

    }
    public void GameStart5()
    {
        int a6 = UnityEngine.Random.Range(1, 100);
        if (a6 > 1 && a6 < p6)
        {
            G5.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i5;
            TLS.SetActive(true);
            o.SetActive(true);

            nowG = G6;
            nowTL = TLS;
            nowTLox = o;
            now = 5; coinChangeNow = i6;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i4;
            TLF.SetActive(true);
            x.SetActive(true);

            nowG = G1;
            nowTL = TLF;
            nowTLox = x;
            now = 0;
            coinChangeNow = i1;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }

    }
    public void GameStart6()
    {
        int a7 = UnityEngine.Random.Range(1, 100);
        if (a7 > 1 && a7 < p7)
        {
            G6.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i6;
            TLS.SetActive(true);
            o.SetActive(true);

            nowG = G7;
            nowTL = TLS;
            nowTLox = o;
            now = 6; coinChangeNow = i7;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i4;
            TLF.SetActive(true);
            x.SetActive(true);

            nowG = G1;
            nowTL = TLS;
            nowTLox = x;
            now = 0;
            coinChangeNow = i1;
            Invoke("Coinchange", 3.8f);
            Invoke("TimeLine", 5.6f);

        }

    }
    public void GameStart7()
    {

        G7.gameObject.SetActive(false);
        G1.gameObject.SetActive(true);
        now = 0;
        coinChangeNow = i1;
        coin.GetComponent<Image>().sprite = i1;
        coinChange.GetComponent<Image>().sprite = coinChangeNow;


    }
    public void Inbutton()
    {
        inButton.SetActive(false);
        outButton.SetActive(true);
        setting.SetActive(true);
    }

    public void outbutton()
    {
        setting.SetActive(false);
        outButton.SetActive(false);
        inButton.SetActive(true);

    }

    void TimeLine()
    {

        FXPanal.SetActive(false);
        nowTL.SetActive(false);
        nowTLox.SetActive(false);
        nowG.gameObject.SetActive(true);
    }
    void Coinchange()
    {

        coin.SetActive(false);
        coinChange.GetComponent<Image>().sprite = coinChangeNow;
        coinChange.SetActive(true);
    }

}
