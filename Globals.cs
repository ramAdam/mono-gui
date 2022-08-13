using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace mono_gui;

class Globals{
    public static ContentManager Content{set;get;}
    public static SpriteBatch SpriteBatch{set;get;}
    public static MouseState LastMouseState{get;set;}
    public static MouseState MouseState{get;set;}
    public static bool Clicked{get;set;}

    public static void Update(){
        
        MouseState = Mouse.GetState();

        Clicked = (MouseState.LeftButton == ButtonState.Pressed && LastMouseState.LeftButton== ButtonState.Released);

        LastMouseState = MouseState;
        
    } 
}