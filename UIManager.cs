using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace mono_gui;

public class UIManager{
    
    private readonly List<Button> buttons = new();
    public Texture2D ButtonTexture{get;}
    public SpriteFont font{get;set;}
    public int Counter {get;set;}
    
    public UIManager(){
        ButtonTexture = Globals.Content.Load<Texture2D>("gfx/button");
        font = Globals.Content.Load<SpriteFont>("font");
    }

    public Button AddButton(Vector2 pos){
        Button b = new(ButtonTexture, pos);
        buttons.Add(b);
        return b;
    }
    public void Update(){
        foreach(var item in buttons){
            item.Update();
        }
    }
    public void Draw(){
        foreach (var item in buttons)
        {
            item.Draw();
        }
        Globals.SpriteBatch.DrawString(font, Counter.ToString(), new(10, 10), Color.Black);
       
    }
}