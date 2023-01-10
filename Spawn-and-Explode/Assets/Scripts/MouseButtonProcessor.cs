using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;
    // need for location of the new character
    GameObject currentCharacter;
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
	{
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0){
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                Vector3 position = currentCharacter.transform.position;
                currentCharacter = Instantiate<GameObject>(
                       prefabTeddyBear, position,
                       Quaternion.identity);
            }
        }
        // explode teddy bear as appropriate
		
	}
}
