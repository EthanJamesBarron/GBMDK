using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.StateSync.BDSM
{
	[RequireComponent(typeof(Rigidbody))]
	public class SubmissiveRigidbody : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadDominantsNextFrame_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SubmissiveRigidbody _003C_003E4__this;

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
			public _003CLoadDominantsNextFrame_003Ed__9(int _003C_003E1__state)
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

		private List<Demand> _Demands;

		private List<IDominant> _Dominants;

		public bool _SyncingAsClient;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void SetSyncing(bool syncing, bool isServer)
		{
		}

		private void Acquiesce()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		private void ConfigureRigidbody(bool isKinematic)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadDominantsNextFrame_003Ed__9))]
		private IEnumerator LoadDominantsNextFrame()
		{
			return null;
		}

		private void SupplicateDemands()
		{
		}
	}
}
