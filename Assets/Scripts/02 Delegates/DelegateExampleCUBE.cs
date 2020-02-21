using UnityEngine;

/*
    Script: DelegateExampleCUBE
    Author: Gareth Lockett
    Version: 1.0
    Description:    Part of the DelegateExample.
                    Attach this script to the cubes.
*/

public class DelegateExampleCUBE : MonoBehaviour
{
    // Methods
    private void Start()
    {
        // Find the DelegateExampleSPHERE component in the scene.
        DelegateExampleSPHERE delegateExampleSPHERE = GameObject.FindObjectOfType<DelegateExampleSPHERE>();

        // Subscribe to the DelegateExampleSPHERE.sphereCollided delegate.
        delegateExampleSPHERE.sphereCollided += this.SphereCollided;
    }

    private void SphereCollided( GameObject gameObject )
    {
        // Check to make sure this component still exists (Eg 'sanity check')
        if( this == null ) { return; }

        // Check to see if the gameObject is this game object. If not, do nothing.
        if( gameObject != this.gameObject ) { return; }

        // If this game object is been collided with, then destroy it.
        Destroy( this.gameObject );
    }
}
