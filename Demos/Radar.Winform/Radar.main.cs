// 此文件由CSharpGL.CSSLGenerator.exe生成。
// 用法：使用CSSL2GLSL.exe编译此文件，即可获得对应的vertex shader, geometry shader, fragment shader。
// 此文件中的类型不应被直接调用，发布release时可以去掉。
// 不可将此文件中的代码复制到其他文件内（如果包含了其他的using ...;，那么CSSL2GLSL.exe就无法正常编译这些代码了。）
namespace CSharpShadingLanguage.Radar
{
    using CSharpShadingLanguage;
    
    
    /// <summary>
    /// 一个<see cref="RadarVert"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// </summary>
    public partial class RadarVert : CSharpShadingLanguage.VertexCSShaderCode
    {
        
        public override void main()
        {
            gl_Position = mvp * vec4(position, 1.0f);
            pass_color = color;
        }
    }
    
    /// <summary>
    /// 一个<see cref="RadarFrag"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// </summary>
    public partial class RadarFrag : CSharpShadingLanguage.FragmentCSShaderCode
    {
        
        public override void main()
        {
            output_color = vec4(pass_color, 1.0f);
        }
    }
}
