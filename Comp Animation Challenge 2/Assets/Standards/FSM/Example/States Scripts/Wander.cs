using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Worq;

namespace Overtime.FSM.Example
{

	public class Wander : StateBase
    {

        [SerializeField]
        AWSPatrol patrol;
        NavControl nav;
        GameObject gate;

        private void Awake()
        {
            patrol = GameObject.Find("RPGHeroHP").GetComponent<AWSPatrol>();
            nav = GameObject.Find("RPGHeroHP").GetComponent<NavControl>();
            gate = GameObject.Find("Gate");
        }

        public override void BuildTransitions()
        {
            AddTransition(StateTransition.START_RUN, StateID.SEEK);
        }

        public override void Enter()
        {
            Debug.Log("Here");
            patrol.enabled = true;
            nav.enabled = false;
        }

        public override void Update()
        {
            if (!gate)
            {
                MakeTransition(StateTransition.START_RUN);
            }
        }
    }
}