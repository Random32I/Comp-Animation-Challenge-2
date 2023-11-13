using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Worq;

namespace Overtime.FSM.Example
{
	public class Seek : StateBase
    {
        [SerializeField]
        AWSPatrol patrol;
        NavControl nav;

        private void Awake()
        {
            patrol = GameObject.Find("RPGHeroHP").GetComponent<AWSPatrol>();
            nav = GameObject.Find("RPGHeroHP").GetComponent<NavControl>();
        }

        public override void BuildTransitions()
        {
            AddTransition(StateTransition.STOP_RUN, StateID.WANDER);
        }

        public override void Enter()
        {
            patrol.enabled = false;
            nav.enabled = true;

        }
    }
}