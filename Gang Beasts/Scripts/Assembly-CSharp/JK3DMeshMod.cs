using UnityEngine;

public abstract class JK3DMeshMod : MonoBehaviour
{
	[ReadOnly]
	[SerializeField]
	public Mesh meshClone;

	public virtual void OnEventSyncStarted(JK3DReference jk3dRef)
	{
	}

	public virtual void OnEventSyncComplete(JK3DReference jk3dRef, bool isBuild)
	{
	}
}
