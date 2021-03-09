using UnityEngine;

public class PlayerAnimationController {
    private PlayerPhysicsController _PlayerPhysicsController;
    private Animator _PlayerAnimator;
    private Vector3 _PlayerMoveDirection;

    public Animator PlayerAnimator { get => _PlayerAnimator; }

    public PlayerAnimationController(Animator playerAnimator, PlayerPhysicsController physicsController) {
        _PlayerAnimator = playerAnimator;
        _PlayerPhysicsController = physicsController;
        _PlayerMoveDirection = Vector3.zero;
    }

    public void GetPlayerMoveDirection() {
        /**
         * @desc Get the current move direction from the player's physics controller 
        */
        _PlayerMoveDirection = _PlayerPhysicsController.GetPlayerMoveDirection();
    }

    public void DetermineAnimationDirection() {
        /**
         * @desc Customizes the current animation state based on the player's physics values and equipped items
        */
        return;
    }

    public void PlayPlayerAnimation() {
        /**
         * @desc Plays the given animation located in the unity animator 
        */
        return;
    }
}
