using UnityEngine;

/*
    Script: GameManager
    Author: Gareth Lockett
    Version: 1.0
    Description:    Simple game manager (NOTE: Like a DM/GM ... needs to know about most of the object types)
*/

public class GameManager : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        // Subscribe to Enemy collisionHappened event.
        Enemy.collisionHappened += this.ACollisionHappened;

        // Subscribe to Player playerDestroyed event.
        Player.playerDestroyed += this.APlayerWasDestroyed;
    }

    private void ACollisionHappened( Enemy enemy, Collision collision )
    {
        // Check if the collision game object has a Player component. If not, do nothing.
        Player player = collision.gameObject.GetComponent<Player>();
        if( player == null ) { return; }

        Debug.Log( "A collision occured between " +enemy.name +" and " +collision.gameObject.name );

        // Do damage to the player using the enemy's amountOfDamageToDo.
        player.TakeDamage( enemy.amountOfDamageToDo );
    }

    private void APlayerWasDestroyed( Player player )
    {
        // Do something when a player is destroyed.
        Debug.Log( player.playerName + " was destroyed." );
    }
}
