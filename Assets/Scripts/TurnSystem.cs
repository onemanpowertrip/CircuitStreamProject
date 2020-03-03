using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Guildmaster
{

    public enum InteractionState
    {
        Start,
        PlayerTurn,
        EnemyTurn,
        Win,
        Lose,


    }
    public class TurnSystem : MonoBehaviour
{
        public GameObject turnMenuCanvas;
        public InteractionState state;
            void Start()
    {
            state = InteractionState.Start;
    }

    // Update is called once per frame
    void Update()
    {
            
    }
        public void SetupInteraction()
        {
            RollInitiative();
            state = InteractionState.PlayerTurn;
        }

        public void RollInitiative()
        {
            
        }

        public void PlayerTurn()
        {
            //Turn on canvas
            turnMenuCanvas.SetActive(true);
            
        }
}

}
