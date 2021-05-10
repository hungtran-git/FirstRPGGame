using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string _horizontal = "Horizontal";
    private string _vertical = "Vertical";
    public Rigidbody2D theRB;
    public int movingSpeed = 10;

    public Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxisRaw(_horizontal));
        theRB.velocity = new Vector2(Input.GetAxisRaw(_horizontal), Input.GetAxisRaw(_vertical)) * movingSpeed;
        myAnimator.SetFloat("moveX", theRB.velocity.x);
        myAnimator.SetFloat("moveY", theRB.velocity.y);

        var axises = new List<float>{-1, 1};
        if(axises.Contains(Input.GetAxisRaw(_horizontal))||axises.Contains(Input.GetAxisRaw(_vertical))) 
        {
            myAnimator.SetFloat("lastMoveX", Input.GetAxisRaw(_horizontal));
            myAnimator.SetFloat("lastMoveY", Input.GetAxisRaw(_vertical));
        }
    }
}
