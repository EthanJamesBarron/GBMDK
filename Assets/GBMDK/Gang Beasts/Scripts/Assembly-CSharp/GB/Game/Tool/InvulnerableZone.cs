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
	public class InvulnerableZone : MonoBehaviour, IActorOnTriggerEvent
	{
		[CompilerGenerated]
		private sealed class _003CInvulnerableUpdate_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InvulnerableZone _003C_003E4__this;

			public Actor actor;

			private float _003Ctimer_003E5__2;

			private int _003CnextlastShow_003E5__3;

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
			public _003CInvulnerableUpdate_003Ed__17(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CReapplyCooldown_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public InvulnerableZone _003C_003E4__this;

			public Actor actor;

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
			public _003CReapplyCooldown_003Ed__19(int _003C_003E1__state)
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
		private bool _reapply;

		[SerializeField]
		private float _timer;

		[SerializeField]
		private Collider _bounds;

		[SerializeField]
		private bool _gainOnEnter;

		[SerializeField]
		private bool _lossOnLeft;

		[SerializeField]
		private bool _invulnerable;

		[SerializeField]
		private bool _immortal;

		[SerializeField]
		private bool _inverse;

		[SerializeField]
		private float _coolDown;

		private Dictionary<Actor, Coroutine> _activeBeasts;

		private void OnEnable()
		{
		}

		private void OnActorStateChangedServer(Actor actor, int connectionID, Actor.ActorState state)
		{
		}

		private void OnDisable()
		{
		}

		private void OnActorDestroyed(Actor obj)
		{
		}

		private void Update()
		{
		}

		private bool InArea(Actor actor)
		{
			return false;
		}

		public void StartInvulnerablility(Actor actor)
		{
		}

		[IteratorStateMachine(typeof(_003CInvulnerableUpdate_003Ed__17))]
		private IEnumerator InvulnerableUpdate(Actor actor)
		{
			return null;
		}

		private void EndInvulnerablility(Actor actor, bool cooldown)
		{
		}

		[IteratorStateMachine(typeof(_003CReapplyCooldown_003Ed__19))]
		private IEnumerator ReapplyCooldown(Actor actor)
		{
			return null;
		}

		public void Event(Actor actor)
		{
		}
	}
}
