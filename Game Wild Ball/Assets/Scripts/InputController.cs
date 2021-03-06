﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(MovementController))]
    public class InputController : MonoBehaviour
    {
        [SerializeField] private MovementController playerMovement;
        private Vector3 movement;
        
        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVars.VERTICAL_AXIS);

            movement = new Vector3(horizontal, 0, vertical).normalized;
        }

        private void FixedUpdate()
        {
            playerMovement.MovePlayer(movement);
            if (Input.GetButtonDown(GlobalStringVars.JUMP_BUTTON))
            {
                playerMovement.JumpPlayer();
            }
        }
    }
}
