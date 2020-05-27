using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lee_Controller : MonoBehaviour
{
 public Rigidbody2D lee;
 public Animator anim; 
    // Start is called before the first frame update
    private void Start()
    {
        

    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            lee.velocity = new Vector2(-5,lee.velocity.y);
            transform.localScale = new Vector2(-1,1);
            anim.SetBool("running",true);
        }
        else if(Input.GetKey(KeyCode.D)){
            lee.velocity = new Vector2(5,lee.velocity.y);
            transform.localScale = new Vector2(1,1);
            anim.SetBool("running",true);
        }
        else{
            anim.SetBool("running",false);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            lee.velocity = new Vector2(lee.velocity.x,10);
        }

    }
}
