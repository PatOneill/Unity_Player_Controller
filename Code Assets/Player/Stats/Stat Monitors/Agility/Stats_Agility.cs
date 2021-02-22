using UnityEngine;

public class Stats_Agility {
    private float _CurrentStamina;
    private float _MaxStamina;
    private float _StaminaRecoveryAmount;
    private float _StaminaRecoveryTime;
    private float _StaminaLastUsed;
    private Stat_Walk _WalkStat;
    private Stat_Sprint _SprintState;

    public Stat_Walk GetWalkStat() { return _WalkStat; }
    public Stat_Sprint GetSprintState() { return _SprintState; }

    public Stats_Agility() {
        _CurrentStamina = 100.0f;
        _MaxStamina = 100.0f;
        _StaminaRecoveryAmount = 1.0f;
        _StaminaRecoveryTime = 0.5f;
        _StaminaLastUsed = 0.5f;
        _WalkStat = new Stat_Walk();
        _SprintState = new Stat_Sprint(this);
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
        _StaminaLastUsed = 0.0f; //Everytime the player performs an action that causes the total stamina to fall, reset the recover time for stamina
    }

    public void StaminaRecoverOverTime() {
        /**
         * @desc Continuously check to see when the player's stamina should start auto refilling as time passes without the player using their stamina
        */
        if (_StaminaLastUsed < _StaminaRecoveryTime) {
            _StaminaLastUsed += Time.deltaTime;
        } else {
            if(_CurrentStamina < _MaxStamina) {
                _CurrentStamina += _StaminaRecoveryAmount;
            }
        }
    }
}
