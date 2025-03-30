Shader "URP FX/Water4" {
	Properties {
		_ReflectionTex ("Internal reflection", 2D) = "white" {}
		_MainTex ("Fallback texture", 2D) = "black" {}
		_ShoreTex ("Shore & Foam texture", 2D) = "black" {}
		_BumpMap ("Normals", 2D) = "bump" {}
		_DistortParams ("Distortions (Bump waves, Reflection, Fresnel power, Fresnel bias)", Vector) = (1,1,2,1.15)
		_InvFadeParemeter ("Blend Parameters (Edge, Foam, Distance, Color)", Vector) = (0.15,0.15,0.5,1)
		_BumpTiling ("Bump Tiling", Vector) = (1,1,-2,3)
		_BumpDirection ("Bump Direction & Speed", Vector) = (1,1,-1,1)
		_FresnelScale ("FresnelScale", Range(0.15, 4)) = 0.75
		_BaseColor ("Base color", Vector) = (0.54,0.95,0.99,0.5)
		_ReflectionColor ("Reflection color", Vector) = (0.54,0.95,0.99,0.5)
		_SpecularColor ("Specular color", Vector) = (0.72,0.72,0.72,1)
		_WorldLightDir ("Specular light direction", Vector) = (0,0.1,-0.5,0)
		_Shininess ("Shininess", Range(2, 500)) = 200
		_FoamIntensity ("Shore Foam Intensity", Range(0, 8)) = 1
		_FoamFadeStart ("Shore Foam Fade-Start", Range(0, 0.999)) = 0.1
		_FoamScale ("Shore Foam Scale", Range(0.125, 8)) = 0.7
		_CrestFoamIntensity ("Crest Foam Intensity", Range(0, 8)) = 0.25
		_CrestFoamScale ("Crest Foam Scale", Range(0.125, 8)) = 4
		_CrestFoamLow ("Crest Foam Low Tweak", Range(0, 1)) = 0
		_CrestFoamHi ("Crest Foam Hi Tweak", Range(0, 1)) = 1
		_WaveHeight ("Wave Height", Float) = 0.4
		_WaveFrequency ("Wave Frequency", Float) = 0.075
		_WaveSpeed ("Wave Speed", Float) = 2
		_WaveDirections ("Planar (World XZ) Wave Directions (1 - XY) (2 - ZW)", Vector) = (-0.6,0,-1,0)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Hidden/InternalErrorShader"
}