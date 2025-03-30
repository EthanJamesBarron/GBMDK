using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Bootstrap;
using UnityEngine;

namespace GB.Core.Bootstrappers
{
	public class NetworkBootstrapper : Bootstrapper
	{
		[CompilerGenerated]
		private sealed class _003CDelayClientBoot_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float seconds;

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
			public _003CDelayClientBoot_003Ed__25(int _003C_003E1__state)
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

		public static string MATCHMAKER_PROXY_ADDRESS;

		public static bool IsDedicatedServer;

		public static bool IsOfficialServer;

		public bool AutoRunServer;

		public bool IsDevServer;

		private bool _autoLaunched;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public void Update()
		{
		}

		protected override void Bootstrap()
		{
		}

		private void OnClientStarted()
		{
		}

		private void OnClientStopped()
		{
		}

		private void OnServerStarted()
		{
		}

		private void OnServerStopped()
		{
		}

		private void OnHostStarted()
		{
		}

		private void OnHostStopped()
		{
		}

		private void OnLocalClientStarted()
		{
		}

		private void OnLocalClientStopped()
		{
		}

		private void OnNetModelResetBegan()
		{
		}

		private void OnNetModelResetComplete()
		{
		}

		private void OnServerPreLoad()
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

		private void BootstrapHost(bool reverse = false)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayClientBoot_003Ed__25))]
		private IEnumerator DelayClientBoot(float seconds)
		{
			return null;
		}
	}
}
