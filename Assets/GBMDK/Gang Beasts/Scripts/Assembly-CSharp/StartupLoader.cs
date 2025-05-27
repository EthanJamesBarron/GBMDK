using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartupLoader : MonoBehaviour
{
	[Serializable]
	public class StringEvent : UnityEvent
	{
	}

	private enum LoadType
	{
		Platform = 0,
		Load = 1
	}

	[CompilerGenerated]
	private sealed class _003CReadyChecker_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartupLoader _003C_003E4__this;

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
		public _003CReadyChecker_003Ed__13(int _003C_003E1__state)
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
	public StringEvent PassedEvent;

	[SerializeField]
	public StringEvent DemoEvent;

	[SerializeField]
	private Slider _loadBar;

	private Coroutine _checkerLooper;

	[SerializeField]
	private LoadType _loadType;

	[SerializeField]
	private bool _loadDataOnEnable;

	private bool _loadedSaveData;

	[SerializeField]
	private bool _runOnLobbySetup;

	private void OnEnable()
	{
	}

	private void GotEntitlement(bool effect)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CReadyChecker_003Ed__13))]
	private IEnumerator ReadyChecker()
	{
		return null;
	}

	private bool Ready()
	{
		return false;
	}

	public void CheckReady()
	{
	}

	private void StartGame()
	{
	}

	private void StartupEvent()
	{
	}

	private void PS4OldSaveLayoutChange(string[] obj)
	{
	}
}
