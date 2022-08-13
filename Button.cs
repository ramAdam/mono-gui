using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace mono_gui;

public class Button
{
    private readonly Texture2D _texture;
    private readonly Rectangle _rect;
    private Vector2 _position;
    private Color _shade = Color.White;
    private MouseState _lastMouseState;
    public Button(Texture2D tex, Vector2 pos)
    {
        _texture = tex;
        _position = pos;
        _rect = new((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
    }

    public void Update(){
        MouseState ms = Mouse.GetState();
        // Rectangle cursor = new(ms.X , ms.Y, 1 ,1 );

        if(_rect.Contains(Globals.MouseState.X, Globals.MouseState.Y)){
            _shade = Color.DarkGray;
            if(Globals.Clicked){
                Click();
            }
        }else{
            _shade = Color.White;
        }
        _lastMouseState = ms;       
    }
    public event EventHandler onClick;

    private void Click(){
        onClick?.Invoke(this, EventArgs.Empty);
    }

    public void Draw(){
        Globals.SpriteBatch.Draw(_texture, _position, _shade);
    }


}