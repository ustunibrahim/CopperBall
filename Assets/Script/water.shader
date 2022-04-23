Shader "Unlit/water"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _RefractTex("Texture", 2D) = "white" {}
       
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag


            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            sampler2D _RefractTex;
           
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;       
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                
            fixed shifter = tex2D(_RefractTex, i.uv + _Time.x).r;
            fixed shifter2 = tex2D(_RefractTex, i.uv + (_Time.x * 0.5f)).r;
            
            shifter /= 10;
            shifter2 /= 20;

            fixed4 col = tex2D(_MainTex, i.uv + shifter + shifter2); 
            col.b *= 5.5f;
            col.r *= 0.1f;
            
            return col;
            }
            ENDCG
        }
    }
}
