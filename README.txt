Simon Johansson

This isn't a full game, just a collection of simple features implemeted using different design patterns.

Patterns:
- State Machine: StateMachine.cs, IdleState.cs, MoveState.cs
  Used a state machine to switch a game objects behavior between idling and moving
- Factory & Pool: MolePool.cs
  Whenever an object is needed from the pool, get the oldest if there is one in the pool, otherwise create one