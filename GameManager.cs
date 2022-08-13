using System;

namespace mono_gui;

public class GameManager{
    private UIManager _ui = new();
    public GameManager(){
        _ui.AddButton(new(100, 100)).onClick += Action;
        _ui.AddButton(new(100, 400)).onClick += Action2;
        _ui.AddButton(new(600, 100)).onClick += Action;
        _ui.AddButton(new(600, 400)).onClick += Action2;

    }

    public void Action(object sender, EventArgs args){
        _ui.Counter++;
    }

    public void Action2(object sender, EventArgs args){
        _ui.Counter--;
    }
    public void Update(){
        _ui.Update();
    }
    public void Draw(){
        _ui.Draw();
    }
}