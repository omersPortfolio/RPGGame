﻿using System;
using UnityEngine;
using UnityEngine.UI;
using RPG.Attributes;
using RPG.Control;

namespace RPG.Combat {
    public class EnemyHealthDisplay : MonoBehaviour
    {
        Fighter fighter;
        Fighter enemyFighter;
        [SerializeField] GameObject enemyHealthPanel;

        private void Awake()
        {
            fighter = GameObject.FindGameObjectWithTag("Player").GetComponent<Fighter>();
        }

        void Update()
        {
            if (fighter.GetTarget() == null)
            {
                GetComponent<Text>().text = "";
                return;
            }

            Health health = fighter.GetTarget();
             GetComponent<Text>().text = String.Format("{0:0}/{1:0}", health.GetHealthPoints(), health.GetMaxHealthPoints());
           
        }
    }

}