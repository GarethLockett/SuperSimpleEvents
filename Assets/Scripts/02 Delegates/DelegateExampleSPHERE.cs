using UnityEngine;

/*
    Script: DelegateExampleSPHERE
    Author: Gareth Lockett
    Version: 1.0
    Description:    Part of the DelegateExample.
                    Attach this script to the sphere.
*/

public class DelegateExampleSPHERE : MonoBehaviour
{
    // Events
    public delegate void SphereCollided( GameObject gameObject );

    // Properties
    public SphereCollided sphereCollided;       // This delegate executes any subscribed methods when called (NOTE: This is like a List< Methods > )

    // Methods
    private void OnCollisionEnter( Collision collision )
    {
        // Invoke any subscribed methods.
        if( this.sphereCollided != null ) { this.sphereCollided.Invoke( collision.gameObject ); }
    }
}
