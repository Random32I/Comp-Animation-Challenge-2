using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Overtime.FSM;

namespace Overtime.FSM.Example
{
	public enum StateID
	{
		WANDER,
		SEEK,
	}

	public enum StateTransition
	{
		START_RUN,
		STOP_RUN,
	}

	public abstract class StateBase : State<FiniteStateMachine, StateID, StateTransition>
	{
		public override void BuildTransitions ()
		{
			
		}

		public override void Enter ()
		{
			
		}

		public override void Exit ()
		{
			
		}

		public override void FixedUpdate ()
		{
			
		}

		public override void Update ()
		{
			
		}
	}
}