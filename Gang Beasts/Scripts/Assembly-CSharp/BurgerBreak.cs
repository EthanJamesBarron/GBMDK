using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BurgerBreak : MonoBehaviour
{
	[Flags]
	public enum BreakLocation
	{
		Top = 1,
		Bottom = 2,
		Left = 4,
		Right = 8
	}

	[CompilerGenerated]
	private sealed class _003CBreakRoutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WaitForSeconds waitForSeconds;

		public BurgerBreak _003C_003E4__this;

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
		public _003CBreakRoutine_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CBreakFirstSide_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BurgerBreak _003C_003E4__this;

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
		public _003CBreakFirstSide_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CBreakSecondSide_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BurgerBreak _003C_003E4__this;

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
		public _003CBreakSecondSide_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CBreakApplyForce_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BurgerBreak _003C_003E4__this;

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
		public _003CBreakApplyForce_003Ed__37(int _003C_003E1__state)
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

	private float m_ImpulseMagnitude;

	public GameObject WheelAxle;

	public float TimeBetweenBreakingPieces;

	private RandomBreak[] m_ConnectedBreakablePieces;

	private Joint[] m_ConnectedJoints;

	private int m_LastBreak;

	private bool m_Broken;

	private WheelRotator m_WheelRotator;

	private GameObject m_WheelTop;

	private Rigidbody m_Rigidbody;

	private Transform m_WheelFrameTransform;

	private Vector3 m_WheelAxlePosition;

	private GameObject m_BurgerTop;

	private Matrix4x4 m_InvAxleTransformNoSpin;

	private BreakLocation m_AllowedFirstBreakLocations;

	private BreakLocation m_AllowedSecondBreakLocations;

	private const float k_BreakTopMin = -60f;

	private const float k_BreakTopMax = 60f;

	private const float k_BreakBottomMin = -120f;

	private const float k_BreakBottomMax = 120f;

	private const float k_BreakLeftMin = -120f;

	private const float k_BreakLeftMax = -60f;

	private const float k_BreakRightMin = 60f;

	private const float k_BreakRightMax = 120f;

	private WaitForSeconds m_WaitTimeBetweenBreakingPieces;

	private WaitForSeconds m_WaitBreakApplyForce;

	private void Start()
	{
	}

	[ContextMenu("Break")]
	public void Break()
	{
	}

	public void ScheduleBreak(WaitForSeconds waitForSeconds, float burgerBreakImpulse, BreakLocation allowedFirstBreakLocations, BreakLocation allowedSecondBreakLocations)
	{
	}

	[IteratorStateMachine(typeof(_003CBreakRoutine_003Ed__30))]
	private IEnumerator BreakRoutine(WaitForSeconds waitForSeconds)
	{
		return null;
	}

	private bool IsWheelSpinningTooFast()
	{
		return false;
	}

	private bool IsOkToBreakFirstSide()
	{
		return false;
	}

	private bool IsOkToBreakSecondSide()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CBreakFirstSide_003Ed__34))]
	private IEnumerator BreakFirstSide()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBreakSecondSide_003Ed__35))]
	private IEnumerator BreakSecondSide()
	{
		return null;
	}

	private void BreakSide()
	{
	}

	[IteratorStateMachine(typeof(_003CBreakApplyForce_003Ed__37))]
	private IEnumerator BreakApplyForce()
	{
		return null;
	}

	private bool CheckBreakLocation(Vector3 position, BreakLocation allowedBreakMask)
	{
		return false;
	}

	private float CalculateAngleAroundTheWheel(Vector3 position)
	{
		return 0f;
	}

	private bool TestBreakLocationFlag(BreakLocation mask, BreakLocation flag)
	{
		return false;
	}
}
