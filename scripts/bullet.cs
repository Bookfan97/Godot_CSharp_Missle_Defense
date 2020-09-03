using Godot;
using System;

public class bullet : Area2D
{
    public int speed = 300;
    Vector2 velocity = new Vector2(0,0);

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("Hello World");
    }

  // Called every frame. '_delta' is the elapsed time since the previous frame.
  public override void _Process(float _delta)
  {
      velocity = Vector2.Right.Rotated(Rotation) * speed * _delta;
       Translate(velocity);
  }
}
