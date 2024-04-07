using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="PlayerController",menuName ="InputController/PlayerController")]
public class PlayerController : InputController
{
    // Start is called before the first frame update
    public override bool RetrieveJumpInput(){
        return Input.GetButtonDown("Jump");
    }
    public override float RetrieveMoveInput(){
        return Input.GetAxisRaw("Horizontal");
    }
}
