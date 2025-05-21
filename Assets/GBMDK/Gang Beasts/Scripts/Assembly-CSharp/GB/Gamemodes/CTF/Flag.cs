using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GB.Game;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Gamemodes.CTF
{
	public class Flag : NetworkBehaviour, IKillTriggered
	{
		[CompilerGenerated]
		private sealed class _003CDestroySelf_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Flag _003C_003E4__this;

			private float _003Ctimer_003E5__2;

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
			public _003CDestroySelf_003Ed__15(int _003C_003E1__state)
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

		[HideInInspector]
		public bool Captured;

		public Action<Flag> OnKilled;

		[SyncVar(hook = "GangIDChanged")]
		private int _gangID;

		[SerializeField]
		private Renderer _targetRenderer;

		[SerializeField]
		private int _materialIndex;

		private Material _targetMaterial;

		public int GangID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private Material TargetMaterial => null;

		public int Network_gangID
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		public void GangIDChanged(int value)
		{
		}

		public void Capture()
		{
		}

		private void UpdateColour()
		{
		}

		public void Kill(KillVolumeEvent trigger)
		{
		}

		[IteratorStateMachine(typeof(_003CDestroySelf_003Ed__15))]
		private IEnumerator DestroySelf()
		{
			return null;
		}

		private void UNetVersion()
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
