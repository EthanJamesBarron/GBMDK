using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.View
{
	public class GBCamera : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBlockInput_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CBlockInput_003Ed__11(int _003C_003E1__state)
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
		private sealed class _003CDelaySceneTransition_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CDelaySceneTransition_003Ed__12(int _003C_003E1__state)
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

		private GameObject _FadePrefab;

		private GameObject _VRGUIPrefab;

		private GameObject _VRGUIRef;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnChangeScene(string name)
		{
		}

		private void OnResetScene()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[IteratorStateMachine(typeof(_003CBlockInput_003Ed__11))]
		private IEnumerator BlockInput()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelaySceneTransition_003Ed__12))]
		private IEnumerator DelaySceneTransition(string newScene)
		{
			return null;
		}

		private void CheckCameraPrepared()
		{
		}
	}
}
