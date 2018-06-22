using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace Assessment1
{


    public class GameManager : MonoBehaviour
    {

        // Restart the damn level
        public void ResetLevel()
        {
            //Find all enemies within the game
            FollowEnemy[] enemies = FindObjectsOfType<FollowEnemy>();
            //Loop through all of them
            for (int i = 0; i < enemies.Length; i++)
            {
                //Reset them
                enemies[i].Reset();
            }

            //Find the player
            PlayerController player = FindObjectOfType<PlayerController>();
            //Reset the player
            player.Reset();
        }
    }
}