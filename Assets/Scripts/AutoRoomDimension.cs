using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AutoRoomDimension : MonoBehaviour {
	public GameObject Floor;
	public GameObject West;
	public GameObject East;
	public GameObject South;
	public GameObject North;
	public GameObject Roof;

	public Vector3 RoomDimensions;
	private Vector3 _OldRoomDimensions;

	private void Update()
	{
		// Apply operations only if the Room dimensions have changed
		if(!RoomDimensions.Equals(_OldRoomDimensions))
		{
			// Planes scale values
			Vector3 WEDim = new Vector3(RoomDimensions.y, 1, RoomDimensions.z);
			Vector3 FRDim = new Vector3(RoomDimensions.x, 1, RoomDimensions.z);
			Vector3 SNDim = new Vector3(RoomDimensions.y, 1, RoomDimensions.x);

			// Planes position values
			float XOffset = RoomDimensions.x * 5.0f;
			float YOffset = RoomDimensions.y * 5.0f;
			float ZOffset = RoomDimensions.z * 5.0f;

			// Update scales
			Floor.transform.localScale = FRDim;
			West.transform.localScale = WEDim;
			East.transform.localScale = WEDim;
			South.transform.localScale = SNDim;
			North.transform.localScale = SNDim;
			Roof.transform.localScale = FRDim;

			// Update positions with Floor always in (0, 0, 0)
			West.transform.localPosition = new Vector3(-XOffset, YOffset, 0);
			East.transform.localPosition = new Vector3(XOffset, YOffset, 0);
			South.transform.localPosition = new Vector3(0, YOffset, -ZOffset);
			North.transform.localPosition = new Vector3(0, YOffset, ZOffset);
			Roof.transform.localPosition = new Vector3(0, 2.0f * YOffset, 0);

			// Store the current dimensions as the previous ones
			_OldRoomDimensions = RoomDimensions;
		}
	}
}
