using UnityEngine;
using System;

/*
    Script: Player
    Author: Gareth Lockett
    Version: 1.0
    Description:    Super simple player script.
*/

[ RequireComponent( typeof( Rigidbody ) ) ]
public class Player : MonoBehaviour
{
    // Events
    public static Action<Player> playerDestroyed;           // An event that is invoked when a Player is destroyed (NOTE: This is like a List< Methods > )

    // Properties
    public string playerName;                               // Name of the player.
    [ SerializeField ] private float health = 10f;          // Amount of health this player has (NOTE: '[ SerializeField ]' is a property attribute)

    // Methods
    public float GetHealth()
    {
        // Return the amount of health this player has (NOTE: This isn't needed for this demo!)
        return this.health;
    }

    public void TakeDamage( float amountOfDamage )
    {
        // Subtract the amount of damage from the health of this player.
        this.health -= amountOfDamage;
        Debug.Log( this.playerName +" took " +amountOfDamage +" damage.");

        // Check health of this player.
        if( this.health <= 0f )
        {
            // Destroy this player if health is less than or equal to zero.
            Destroy( this.gameObject );
        }
    }

    private void OnDestroy()
    {
        // Invoke any subscribed playerDestroyed events.
        if( Player.playerDestroyed != null ) { Player.playerDestroyed.Invoke( this ); }
    }
}
