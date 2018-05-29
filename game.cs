using System;
using System.IO;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Template {

class Game
{
	// member variables
	public Surface screen;
	// initialize
	public void Init()
	{
	}
	// tick: renders one frame
	public void Tick()
	{
		screen.Clear( 0 );
        
		
	}

    public void RenderGL()
    {
        GL.Enable( EnableCap.DepthTest );
        GL.Disable( EnableCap.Texture2D );
        GL.Clear( ClearBufferMask.DepthBufferBit );
        GL.Color3( 1.0f, 0.0f, 0.0f );
        GL.Begin( PrimitiveType.Triangles );
        GL.Vertex3( -0.1f, -0.1f, 0 );
        GL.Vertex3( 0.1f, -0.1f, 0 );
        GL.Vertex3( -0.1f, 0.1f, 0 );
        GL.End();      
    }
}

} // namespace Template