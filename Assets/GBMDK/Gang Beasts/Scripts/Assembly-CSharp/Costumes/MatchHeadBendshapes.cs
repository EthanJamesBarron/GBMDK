using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Costumes
{
	public class MatchHeadBendshapes : MonoBehaviour
	{
		[Serializable]
		public class BlendPartialName
		{
			public string ThisBlendName;

			public string HeadName;
		}

		[CompilerGenerated]
		private sealed class _003CFindHeadSkinnedMeshRenderer_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MatchHeadBendshapes _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CFindHeadSkinnedMeshRenderer_003Ed__10(int _003C_003E1__state)
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

		public string HeadSkrGoName;

		public int RetryFindTimes;

		public float TimeInbetweenRetrys;

		public SkinnedMeshRenderer HeadSkm;

		public SkinnedMeshRenderer ThisSkm;

		public BlendPartialName[] BlendPartialNames;

		public int[] _blendshaps;

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CFindHeadSkinnedMeshRenderer_003Ed__10))]
		private IEnumerator FindHeadSkinnedMeshRenderer()
		{
			return null;
		}

		private Transform FindTransformByPartialName(string name, Transform trans)
		{
			return null;
		}
	}
}
