using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
   private void HandleMovement()
   {
       if(isLocalPlayer)
       {
           float moveHorizonal = Input.GetAxis("Horizontal");
           float moveVertical = Input.GetAxis("Vertical");
           Vector3 movement = new Vector3(moveHorizonal * 0.2f,moveVertical * 0.2f, 0);
           transform.position = transform.position + movement;
       }
   }
   void Update()
   {
       HandleMovement();
   }
    
}
