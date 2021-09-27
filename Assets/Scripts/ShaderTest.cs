using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ShaderTest : MonoBehaviour
{
    public Camera _cam;
    public Material mat;
    public Texture2D depth;

    public float DepthLevel = 1.0F;

    void Start()
    {
        _cam.depthTextureMode |= DepthTextureMode.Depth;
    }

    void Update()
    {
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        mat.SetFloat("_DepthLevel", DepthLevel);
        Graphics.Blit(source, destination, mat);
    }
}