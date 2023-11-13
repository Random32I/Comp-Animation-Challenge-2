using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Overtime.FSM;

namespace Overtime.FSM.Example
{
    public class FiniteStateMachine : MonoBehaviour
    {
        private StateMachine<FiniteStateMachine, StateID, StateTransition> m_FSM;
        public StateMachine<FiniteStateMachine, StateID, StateTransition> FSM
        {
            get { return m_FSM; }
        }

        public StateID m_InitialState;

        public ScriptableObject[] m_States;

        public bool m_Debug;

        void OnDestroy()
        {
            m_FSM.Destroy();
        }

        void Start()
        {
            m_FSM = new StateMachine<FiniteStateMachine, StateID, StateTransition>(this, m_States, m_InitialState, m_Debug);
        }

        void Update()
        {
            m_FSM.Update();
        }

        void FixedUpdate()
        {
            m_FSM.FixedUpdate();
        }

        void OnTriggerEnter(Collider col)
        {
            m_FSM.OnTriggerEnter(col);
        }

#if UNITY_EDITOR
        void OnGUI()
        {
            if (m_Debug)
            {
                GUI.color = Color.white;
                GUI.Label(new Rect(0.0f, 0.0f, 500.0f, 500.0f), string.Format("State: {0}", FSM.CurrentStateName));
            }
        }
#endif
    }
}
