using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    
    public Model _model;
    public View _view;
    private Rigidbody2D rb;
     
    
   public Controller(Model model, View view)

    {
        _model = model;
        _view = view;
    }

    public void FlyBird()
    {   //bird is jump
         rb.velocity = Vector2.up * _model.velocity;
    }

       
    
}
