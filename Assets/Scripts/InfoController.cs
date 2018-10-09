using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class InfoController:MonoBehaviour
    {
        [SerializeField]
        private Text distance;
        [SerializeField]
        private Text timer;
        [SerializeField]
        private Text speed;

        private Movement movement; 
        void Start()
        {
            movement = GetComponent<Movement>();
            movement.OnUpdateUIInfo+=ShowInfo;
        }
        void OnDisable()
        {
            movement.OnUpdateUIInfo -= ShowInfo;
        }
        private void ShowInfo(float dist, float countTimer,float velocity)
        {
            this.distance.text = "Distance: " +(int) dist + " meter";
            this.timer.text = "Timer: " +(int)countTimer + " second";
            this.speed.text = "Speed: " +(int) velocity + " m/s";
        }
    }
}
