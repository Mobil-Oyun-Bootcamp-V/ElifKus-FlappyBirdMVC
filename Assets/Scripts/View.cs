using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody2D rb;

    public Controller _controller;
     public static int score = 0;

    public View(Controller controller)
    {
        _controller=controller;
    }
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();

         score=0;
         
    }

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();

        //mouse click olursa kusumuzun ucmasi icin fonksiyon cagrilir.
        if(Input.GetMouseButtonDown(0)){

            _controller.FlyBird();

        }
         
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //herhangi bir carpma durumu icin olum fonksiyonu
        gameManager.GameOver();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //score artirim islemi
        Score.score++;
    }


    
}
