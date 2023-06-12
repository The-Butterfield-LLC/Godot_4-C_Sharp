using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private const float flapPower = 5;

	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Adding Gravity all the time
		velocity.Y += gravity * (float)delta;		
		
		// Flap Action
		if (Input.IsActionJustPressed("flap"))
		{
			velocity.Y = FlapAction(velocity);
		}



		Velocity = velocity;
		MoveAndSlide();
	}

	public double FlapAction(Vector2 velocity)
	{
		
		GD.Print("Hello" + velocity);
		return velocity.Y -= flapPower;

	}
}
