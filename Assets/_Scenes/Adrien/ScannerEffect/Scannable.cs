using UnityEngine;
using System.Collections;

public class Scannable : MonoBehaviour
{
	public Material Lit;
	public Material Unlit;
	public Renderer Render;
	public float ScanRevealDurationInMS;
	public bool Scanned;
	public float LitSpeed = 4.0f;

	private float _StartTime;

	private void Start()
	{
		_StartTime = -1;
	}

	public void Ping()
	{
		PingMaterial();
		Scanned = true;
	}

	private Coroutine PingMaterial()
	{
		return StartCoroutine(MaterialLerp());
	}

	private IEnumerator MaterialLerp()
	{
		float start = Time.realtimeSinceStartup * 1000.0f;
		float elapsedTime = 0.0f;
		float t = 0.0f;
		float fadeInDuration = (ScanRevealDurationInMS / LitSpeed);
		Material src, dest;

		while ((Time.realtimeSinceStartup * 1000.0f) - start < ScanRevealDurationInMS)
		{
			elapsedTime = (Time.realtimeSinceStartup * 1000.0f) - start;
			
			if(elapsedTime < fadeInDuration)
			{
				t = elapsedTime / fadeInDuration;
				src = Unlit;
				dest = Lit;
			}
			else
			{
				t = (elapsedTime - fadeInDuration) / (ScanRevealDurationInMS - fadeInDuration);
				src = Lit;
				dest = Unlit;
			}

			Render.material.Lerp(src, dest, t);

			yield return 1;
		}

		Render.material = Unlit;
	}
}