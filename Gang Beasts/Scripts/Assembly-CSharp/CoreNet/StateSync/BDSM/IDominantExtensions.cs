using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CoreNet.StateSync.BDSM
{
	public static class IDominantExtensions
	{
		[CompilerGenerated]
		private sealed class _003CLoadSubmissiveOffsetsNextFrame_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public IDominant dominant;

			public Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets;

			public Transform transform;

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
			public _003CLoadSubmissiveOffsetsNextFrame_003Ed__0(int _003C_003E1__state)
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

		[IteratorStateMachine(typeof(_003CLoadSubmissiveOffsetsNextFrame_003Ed__0))]
		public static IEnumerator LoadSubmissiveOffsetsNextFrame(this IDominant dominant, Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets, Transform transform)
		{
			return null;
		}

		public static void LoadSubmissiveOffsets(this IDominant dominant, Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets, Transform transform)
		{
		}

		public static Demand CreateDemand(this IDominant dominant, SubmissiveRigidbody sub, Dictionary<SubmissiveRigidbody, Vector3> submissiveOffsets, Transform transform)
		{
			return null;
		}
	}
}
