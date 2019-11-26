using UnityEngine;

public class ScreenshotHandler : MonoBehaviour
{
	private static ScreenshotHandler instance;
	private Camera camera;
	private bool takeScreenshotOnNextFrame;

	private void Awake()
	{
		instance = this;
		camera = gameObject.GetComponent<Camera>();
	}

	private void OnPostRender()
	{
		if (takeScreenshotOnNextFrame)
		{
			takeScreenshotOnNextFrame = false;
			RenderTexture renderTexture = camera.targetTexture;

			Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
			Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
			renderResult.ReadPixels(rect, 0, 0);

			byte[] byteArray = renderResult.EncodeToPNG();
			System.IO.File.WriteAllBytes(Application.dataPath + "/CharacterPhotobooth.png", byteArray);
			Debug.Log("Picture taken!");

			RenderTexture.ReleaseTemporary(renderTexture);
			camera.targetTexture = null;
		}
	}

	private void TakeScreenshot(int width, int height)
	{
		camera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
		takeScreenshotOnNextFrame = true;
	}

	public static void TakeScreenshot_Static(int width, int height)
	{
		instance.TakeScreenshot(width, height);
	}
}
