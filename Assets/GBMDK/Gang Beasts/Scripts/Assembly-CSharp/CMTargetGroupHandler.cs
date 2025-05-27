using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using Femur;
using GB.Networking.Objects;
using UnityEngine;

public class CMTargetGroupHandler : MonoBehaviour
{
	private struct GroupTargetWeight
	{
		public Transform t;

		public CinemachineTargetGroup g;

		public int idx;

		public float curWeight;

		public float goalWeight;
	}

	public delegate void CamTargetsChangedDel();

	public delegate void SpectatingTargetDel(CinemachineTargetGroup.Target t);

	[CompilerGenerated]
	private sealed class _003CRemoveFromGroup_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TargetGroupAndTrackingInfo targetAndTracking;

		public CMTargetGroupHandler _003C_003E4__this;

		public CMTrackedObject trackedObject;

		private bool _003CisLocalGroup_003E5__2;

		private bool _003CisLocalGangMember_003E5__3;

		private CinemachineTargetGroup _003Cgroup_003E5__4;

		private bool _003CSwapToSpectator_003E5__5;

		private bool _003Cweight_003E5__6;

		private bool _003Cradius_003E5__7;

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
		public _003CRemoveFromGroup_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CGroupTargetWeightRoutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CMTargetGroupHandler _003C_003E4__this;

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
		public _003CGroupTargetWeightRoutine_003Ed__53(int _003C_003E1__state)
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

	public CMTargetGroupPool TargetGroupPool;

	private List<CMTrackedObject> trackedObjects;

	private List<CMVcamTargeter> vCams;

	public int ItemsBeingTracked;

	public float remoteActorDistanceThreshold;

	public float remoteActorDistanceMaxThreshold;

	public static float _HumanTrackingWeight;

	public static float _HumanTrackingRadius;

	public static float _AITrackingWeight;

	public static float _AITrackingRadius;

	public float WeightLerpSpeed;

	public float RadiusLerpSpeed;

	private bool RoundSetupComplete;

	private bool Spectating;

	private CinemachineTargetGroup.Target _SpectatingTarget;

	public bool TrackAI;

	public float DeadBeastRemovalDelay;

	private static CMTargetGroupHandler _instance;

	public float newTargetInterpolateTime;

	private Coroutine groupTargetWeightRoutine;

	private List<GroupTargetWeight> newlyAddedTargets;

	public CamTargetsChangedDel OnTrackingTargetChanged;

	public SpectatingTargetDel OnLocalGroupDead;

	public List<CMTrackedObject> TrackedObjects => null;

	public List<CMVcamTargeter> VirtualCameras => null;

	public static CMTargetGroupHandler Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	private void OnGameSetup()
	{
	}

	private void Start()
	{
	}

	private void RegisterForNetworkManagerEvents()
	{
	}

	public void AddTrackedObject(CMTrackedObject obj)
	{
	}

	public void RemoveTrackedObject(CMTrackedObject obj)
	{
	}

	public void AddVcam(CMVcamTargeter cam)
	{
	}

	public void RemoveVcam(CMVcamTargeter cam)
	{
	}

	[IteratorStateMachine(typeof(_003CRemoveFromGroup_003Ed__33))]
	private IEnumerator RemoveFromGroup(CMTrackedObject trackedObject, TargetGroupAndTrackingInfo targetAndTracking)
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnGameEnded()
	{
	}

	private void OnPreLevelLoad()
	{
	}

	public void OnClientStarted()
	{
	}

	private void ResetTrackedObjects()
	{
	}

	public void OnClientStopped()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnNetGangAdded(NetGang gang)
	{
	}

	private void OnNetGangUpdated(NetGang gang)
	{
	}

	private void OnNetGangRemoved(NetGang gang)
	{
	}

	public Actor GetActorFromTransform(Transform Ball)
	{
		return null;
	}

	private void FillTargetGroups(TargetGroupAndTrackingInfo targetAndTracking, bool isLocalGame)
	{
	}

	public CMVcamTargeter GetActiveCamera()
	{
		return null;
	}

	private void SetBeastAsGroupTarget(Actor beasts, TargetGroupAndTrackingInfo targetAndTracking, bool localGame)
	{
	}

	private void RefreshTrackingWeight(TargetGroupAndTrackingInfo oldTargetsInfo, int groupIdx)
	{
	}

	[IteratorStateMachine(typeof(_003CGroupTargetWeightRoutine_003Ed__53))]
	private IEnumerator GroupTargetWeightRoutine()
	{
		return null;
	}

	public void RefreshTargetGroups()
	{
	}

	public void RefreshGangs()
	{
	}

	private void OnActorSetup(Actor actor)
	{
	}

	private void OnNetBeastAdded(NetBeast beast)
	{
	}

	private void OnNetBeastUpdated(NetBeast beast)
	{
	}

	private void OnNetBeastRemoved(NetBeast beast)
	{
	}

	private void CheckForNullTrackedObject()
	{
	}

	public int GetLocalPlayersInGang(TargetGroupAndTrackingInfo targetAndTrackingInfo)
	{
		return 0;
	}
}
