using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Bootstrap;
using GB.Networking;
using UnityEngine;

namespace CoreNet.Bootstrap
{
	public class CoreNetBootstrapper : Bootstrapper
	{
		[CompilerGenerated]
		private sealed class _003COnSessionDataInternal_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003COnSessionDataInternal_003Ed__8(int _003C_003E1__state)
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
		private sealed class _003COnReset_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CoreNetBootstrapper _003C_003E4__this;

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
			public _003COnReset_003Ed__18(int _003C_003E1__state)
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

		public static Action OnNetModelResetBegan;

		public static Action OnNetModelResetComplete;

		private const float sessionStartTimeout = 15f;

		private static float sessionStartTimer;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void FlushEvents()
		{
		}

		protected override void Bootstrap()
		{
		}

		private void OnGBSessionDataReceived(GBSessionData sessionData)
		{
		}

		[IteratorStateMachine(typeof(_003COnSessionDataInternal_003Ed__8))]
		private IEnumerator OnSessionDataInternal(GBSessionData sessionData)
		{
			return null;
		}

		private void OnLocalPlayerStarted()
		{
		}

		private void OnLocalPlayerStopped()
		{
		}

		private void OnClientPreLoad()
		{
		}

		private void OnClientStarted()
		{
		}

		private void OnClientStopped()
		{
		}

		private void OnServerPreLoad()
		{
		}

		private void OnServerStarted()
		{
		}

		private void OnServerStopped()
		{
		}

		private void OnNetCleanup()
		{
		}

		[IteratorStateMachine(typeof(_003COnReset_003Ed__18))]
		private IEnumerator OnReset()
		{
			return null;
		}

		private void BootstrapClientPreLoad(bool reverse = false)
		{
		}

		private void BootstrapClient(bool reverse = false)
		{
		}

		private void BootstrapLocalClient(bool reverse = false)
		{
		}

		private void BootstrapServerPreLoad(bool reverse = false)
		{
		}

		private void BootstrapServer(bool reverse = false)
		{
		}
	}
}
