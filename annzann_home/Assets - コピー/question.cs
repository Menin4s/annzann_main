using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour
{ 
    public Text textUI;
    public int qcount = 0;


    // Start is called before the first frame update
    void Start()
    {
        int a = Random.Range(1, 20);
        int b = Random.Range(1, 20);
        int c = a + b;
        int[] ans = { c, c - 1, c + 1, c + 3 };

        //‰ñ“š‚ÌƒVƒƒƒbƒtƒ‹
        for (int i = 0; i < ans.Length; i++)
        {
            int temp = ans[i];
            int rans = Random.Range(0, ans.Length);
            ans[i] = ans[rans];
            ans[rans] = temp;
        }


        Text qStr = GameObject.Find("Canvas").transform.Find("Question").GetComponent<Text>();
        Text ansStr1 = GameObject.Find("Canvas/ansButton1").transform.Find("Text").GetComponent<Text>();
        Text ansStr2 = GameObject.Find("Canvas/ansButton2").transform.Find("Text").GetComponent<Text>();
        Text ansStr3 = GameObject.Find("Canvas/ansButton3").transform.Find("Text").GetComponent<Text>();
        Text ansStr4 = GameObject.Find("Canvas/ansButton4").transform.Find("Text").GetComponent<Text>();

        qStr.text = a + " + " + b + " = ";
        ansStr1.text = (ans[0]).ToString();
        ansStr2.text = (ans[1]).ToString();
        ansStr3.text = (ans[2]).ToString();
        ansStr4.text = (ans[3]).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void AnswerLabelSet()
    {

    }
}
