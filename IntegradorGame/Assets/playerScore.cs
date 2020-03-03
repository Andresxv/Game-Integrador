using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;


public class playerScore : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    public static string playerName;
    private System.Random random= new System.Random();
    public InputField nameText;
    
    // Start is called before the first frame update
    void Start()
    {
        score = random.Next(1000);
        scoreText.text="puntaje: "+score;
    }
    public void OnSumit()
    {
        playerName = nameText.text;
        dataBase();
    }
    private void dataBase()
    {
        user user = new user();
        RestClient.Put("https://usuarios-ff410.firebaseio.com/", user);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
