using UnityEngine;
using System;

/*
    Script: Enemy
    Author: Gareth Lockett
    Version: 1.0
    Description:    Super simple enemy script.
*/

[ RequireComponent( typeof( Rigidbody ) ) ]
public class Enemy : MonoBehaviour
{
    // Events
    public static Action<Enemy,Collision> collisionHappened;        // An event that is invoked when something collides with this game obejct.

    // Properties
    public float amountOfDamageToDo = 2f;                           // Amount of damage this enemy will do to the player when it collides.

    // Methods
    private void OnCollisionStay( Collision collision )
    {
        // Invoke any subscribed collisionHappened methods.
        if( Enemy.collisionHappened != null ) { Enemy.collisionHappened.Invoke( this, collision ); }
    }
}
