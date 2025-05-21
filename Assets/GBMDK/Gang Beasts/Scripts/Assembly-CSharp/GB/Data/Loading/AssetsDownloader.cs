using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.UI.Utils;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	public class AssetsDownloader : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public bool needToReload;

			internal void _003CDownload_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDownload_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetsDownloader _003C_003E4__this;

			public int endStep;

			public int startStep;

			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

			private int _003CtotalStep_003E5__2;

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
			public _003CDownload_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CStartDownload_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetsDownloader _003C_003E4__this;

			public int startStep;

			public int totalStep;

			private AsyncOperationHandle _003CdownloadHandle_003E5__2;

			private float _003Cprogress_003E5__3;

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
			public _003CStartDownload_003Ed__17(int _003C_003E1__state)
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

		public readonly IList Assets;

		public LoadingBar LoadingBar { get; set; }

		private bool IsDownloading { get; set; }

		private AsyncOperationStatus DownloadingStatus { get; set; }

		private bool IsDownloadSuccessfully => false;

		public void Reset()
		{
		}

		[IteratorStateMachine(typeof(_003CDownload_003Ed__16))]
		public IEnumerator Download(int startStep, int endStep)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStartDownload_003Ed__17))]
		private IEnumerator StartDownload(int startStep, int totalStep)
		{
			return null;
		}
	}
}
