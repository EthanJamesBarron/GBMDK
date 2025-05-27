using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI
{
	public class CostumeMultiModalHandler : ModalHandler
	{
		private class CostumeModalStatus
		{
			public int _controlID;

			public bool _ready;

			public bool _nulled;

			public CostumeModalStatus(int id)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCountdownCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CostumeMultiModalHandler _003C_003E4__this;

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
			public _003CCountdownCoroutine_003Ed__13(int _003C_003E1__state)
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
		private CostumeSelectModal[] ModalRefs;

		private CostumeModalStatus[] ModalStatuses;

		[SerializeField]
		private Text CountdownUI;

		[SerializeField]
		private float CountdownTimerLength;

		private float countdownTimer;

		private Coroutine countdownCoroutine;

		public override void PreInitialise(List<object> parameters)
		{
		}

		public void AlertHandlerPlayerReady(int id)
		{
		}

		public void CheckStartTimer()
		{
		}

		public void AlertHandlerPlayerUnready(int id)
		{
		}

		public void AlertHandlerNulled(int id)
		{
		}

		public void AlertHandlerUnnulled(int id)
		{
		}

		[IteratorStateMachine(typeof(_003CCountdownCoroutine_003Ed__13))]
		private IEnumerator CountdownCoroutine()
		{
			return null;
		}

		private void StopGameStartCountdown()
		{
		}

		private void Update()
		{
		}
	}
}
