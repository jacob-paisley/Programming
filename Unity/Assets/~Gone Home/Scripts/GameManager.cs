using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GoneHome
{


    public class GameManager : MonoBehaviour
    {

        public void NextLevel ()
        {
            // Get the current loaded scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load the one next to it (using buildIndex)
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

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
            Player player = FindObjectOfType<Player>();
            //Reset the player
            player.Reset();
        }
    }
}