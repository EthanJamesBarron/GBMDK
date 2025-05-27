using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Femur;
using GB.Game.Tool.ActorEvents;
using UnityEngine;

namespace GB.Game.Tool
{
	public class NotifyBeastInfo : MonoBehaviour, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CShowLogic_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NotifyBeastInfo _003C_003E4__this;

			public Actor actor;

			private float _003Ctimer_003E5__2;

			private int _003ClastTime_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowLogic_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private bool _notifyAI;

		[SerializeField]
		private bool _showNamebars;

		[SerializeField]
		private bool _vibController;

		[SerializeField]
		private float _forTime;

		private Dictionary<Actor, Coroutine> _activeInformers;

		private void OnDisabled()
		{
		}

		public void Event(Actor actor)
		{
		}

		[IteratorStateMachine(typeof(_003CShowLogic_003Ed__7))]
		private IEnumerator ShowLogic(Actor actor)
		{
			return null;
		}
	}
}
