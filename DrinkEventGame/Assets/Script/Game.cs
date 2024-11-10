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
    GameObject nowG;


    public GameObject coin;
    public Sprite i1;
    public Sprite i2;
    public Sprite i3;
    public Sprite i4;
    public Sprite i5;


    public GameObject FXPanal;
    public GameObject TL0;
    public GameObject TL1;
    public GameObject TL2;
    public GameObject TL3;
    public GameObject TL4;
    public GameObject TL5;
    GameObject nowTL;

    public GameObject inButton;
    public GameObject outButton;
    public GameObject setting;

    public TMP_InputField f2;
    public TMP_InputField f3;
    public TMP_InputField f4;
    public TMP_InputField f5;
    int p2 = 1;
    int p3 = 1;
    int p4 = 1;
    int p5 = 1;

    public TMP_Text Num1;
    public TMP_Text Num2;
    public TMP_Text Num3;
    public TMP_Text Num4;
    public TMP_Text Num5;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        p2 = int.Parse(f2.text);
        p3 = int.Parse(f3.text);
        p4 = int.Parse(f4.text);
        p5 = int.Parse(f5.text);

        Num1.text = 100.ToString();
        Num2.text = (Mathf.Floor((100f/p2)*100)/100).ToString();
        Num3.text = (Mathf.Floor((100f/p3)*100)/100).ToString();
        Num4.text = (Mathf.Floor((100f/p4)*100)/100).ToString();
        Num5.text = (Mathf.Floor((100f/p5)*100)/100).ToString();
       

      



    }
    public void GameStart1()
    {
        int a2 = UnityEngine.Random.Range(1, p2);
        if (a2 == 1)
        {
            G1.gameObject.SetActive(false);

            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i1;
            nowTL = TL2;
            nowG = G2;
            Invoke("TimeLine", 3);


        }
        else
        {
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i1;
            nowTL = TL1;
            nowG = G1;
            Invoke("TimeLine", 3);
        }

    }
    public void GameStart2()
    {
        int a3 = UnityEngine.Random.Range(1, p3);
        if (a3 == 1)
        {
            G2.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i2;
            nowTL = TL3;
            nowG = G3;
            Invoke("TimeLine", 3);
        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i2;
            nowTL = TL1;
            nowG = G1;
            Invoke("TimeLine", 3);
        }

    }
    public void GameStart3()
    {
        int a4 = UnityEngine.Random.Range(1, p4);
        if (a4 == 1)
        {
            G3.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i3;
            nowTL = TL4;
            nowG = G4;
            Invoke("TimeLine", 3);
        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i3;
            nowTL = TL1;
            nowG = G1;
            Invoke("TimeLine", 3);
        }

    }
    public void GameStart4()
    {
        int a5 = UnityEngine.Random.Range(1, p5);
        if (a5 == 1)
        {
            G4.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i4;
            nowTL = TL5;
            nowG = G5;
            Invoke("TimeLine", 3);
        }
        else
        {
            nowG.gameObject.SetActive(false);
            G1.gameObject.SetActive(false);
            FXPanal.SetActive(true);
            coin.GetComponent<Image>().sprite = i4;
            nowTL = TL1;
            nowG = G1;
            Invoke("TimeLine", 3);
        }

    }
    public void GameStart5()
    {

        G5.gameObject.SetActive(false);
        G1.gameObject.SetActive(true);


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

        TL0.SetActive(true);
        FXPanal.SetActive(false);
        nowTL.SetActive(true);
        Invoke("TimeLineOut", 3);

    }

    void TimeLineOut()
    {
        nowTL.SetActive(false);
        TL0.SetActive(false);
        nowG.gameObject.SetActive(true);
    }
}
