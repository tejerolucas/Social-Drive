Shader "Custom/cutalpha" 
{
	Properties 
	{
		_MainTex ("Alpha (RGB)", 2D) = "white" {}
		_MainTex2 ("Base (RGB)", 2D) = "white" {}

		_Alpha("Range", Range(0,1)) = 0
	}
	SubShader 
	{
		Pass
		{
		
			AlphaTest Greater[_Alpha]

			SetTexture[_MainTex]

			SetTexture[_MainTex2]
			{
				Combine Texture * Previous
			}
		}
	} 
	FallBack "Diffuse"
}
