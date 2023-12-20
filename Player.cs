using Godot;
using System;

public partial class Player : RigidBody2D
{

    public int Force { get; set; } = 1500;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
    }

    public override void _PhysicsProcess(double delta)
    {

        if(Input.IsActionPressed("move_right"))
        {
            ApplyForce(new Vector2(Force, 0));
        }

        if (Input.IsActionPressed("move_left"))
        {
            ApplyForce(new Vector2(-Force, 0));
        }

        if (Input.IsActionPressed("move_up"))
        {
            ApplyForce(new Vector2(0, -Force));
        }

        if (Input.IsActionPressed("move_down"))
        {
            ApplyForce(new Vector2(0, Force));
        }
    }
}
