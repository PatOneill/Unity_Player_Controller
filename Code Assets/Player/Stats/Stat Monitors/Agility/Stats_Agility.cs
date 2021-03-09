using UnityEngine;

public class Stats_Agility {
    private float _CurrentStamina;
    private float _MaxStamina;
    private float _StaminaRecoveryAmount;
    private float _StaminaRecoveryTime;
    private float _TimeSinceLastDecreaseInStamina;
    private Stat_Walk _WalkStat;
    private Stat_Sprint _SprintStat;
    private Stat_CrouchWalk _CrouchWalkStat;
    private PlayerHUDController _HUDControllerPlayer;

    public Stat_Walk GetWalkStat() { return _WalkStat; }
    public Stat_Sprint GetSprintStat() { return _SprintStat; }
    public Stat_CrouchWalk GetCrouchWalkStat() { return _CrouchWalkStat; }

    public Stats_Agility(PlayerHUDController hudController) {
        _CurrentStamina = 100.0f;
        _MaxStamina = 100.0f;
        _StaminaRecoveryAmount = 0.05f;
        _StaminaRecoveryTime = 8.0f;
        _TimeSinceLastDecreaseInStamina = 0.0f;
        _WalkStat = new Stat_Walk();
        _SprintStat = new Stat_Sprint(this);
        _CrouchWalkStat = new Stat_CrouchWalk();
        _HUDControllerPlayer = hudController;
    }

    public bool IsThereEnoughStamina(float cost) {
        /**
         * @desc Check to see if there is currently enough stamina in reserve for the player to perform a particular action
         * @parm float $cost - The cost in stamina for a particular action
        */
        if (_CurrentStamina - cost >= 0.0f) {
            return true;
        } else {
            return false;
        }
    }

    public void LowerStamina(float decayValue) {
        /**
         * @desc Lower the player's current stamina value when the player performs an action that costs stamina 
         * @parm float $decayValue - The cost in stamina for a particular action
        */
        _CurrentStamina -= decayValue;
        _HUDControllerPlayer.StaminaWasIncreased(_CurrentStamina / _MaxStamina); //Inform the player's HUD that it needs to update the stamina bar
        _TimeSinceLastDecreaseInStamina = 0.0f; //Everytime the player performs an action that causes the total stamina to fall, reset the recover time for stamina
    }

    public void StaminaRecoverOverTime() {
        /**
         * @desc Continuously check to see when the player's stamina should start auto refilling as time passes without the player using their stamina
        */
        if(_CurrentStamina == _MaxStamina) { //Skip recover clock if player already has max stamina
            return;
        } else {
            if (_TimeSinceLastDecreaseInStamina < _StaminaRecoveryTime) {
                _TimeSinceLastDecreaseInStamina += Time.deltaTime;
            } else {
                if (_CurrentStamina < _MaxStamina) {
                    _CurrentStamina += _StaminaRecoveryAmount;
                    if (_CurrentStamina > _MaxStamina) { //Ensure the player's stamina does not recover more stamina than the max amount
                        _CurrentStamina = _MaxStamina;
                    }
                    _HUDControllerPlayer.StaminaWasDecreased(_CurrentStamina/_MaxStamina); //Inform the player's HUD that it needs to update the stamina bar
                }
            }
        }
    }
}
