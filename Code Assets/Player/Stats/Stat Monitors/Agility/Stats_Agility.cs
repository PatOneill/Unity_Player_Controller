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
    private UI_HudFunctionality _HudFunctionality;
    private Mediator_Proxies _ProxiesMediator;

    public Mediator_Proxies ProxiesMediator { set => _ProxiesMediator = value; }

    public Stat_Walk GetWalkStat() { return _WalkStat; }
    public Stat_Sprint GetSprintStat() { return _SprintStat; }
    public Stat_CrouchWalk GetCrouchWalkStat() { return _CrouchWalkStat; }

    public Stats_Agility(PlayerUIController uiController) {
        _CurrentStamina = 100.0f;
        _MaxStamina = 100.0f;
        _StaminaRecoveryAmount = 0.05f;
        _StaminaRecoveryTime = 8.0f;
        _TimeSinceLastDecreaseInStamina = 0.0f;
        _ProxiesMediator = null;
        _WalkStat = new Stat_Walk();
        _SprintStat = new Stat_Sprint(this);
        _CrouchWalkStat = new Stat_CrouchWalk();
        _HudFunctionality = uiController.GetHudControllerUI().GetHudFunctionalityUI();
    }

    public void OnStart() {
        /**
         * @desc Called before the first update, this method sets up player's stat class's fields to interact with mediators if needed
        */
        _SprintStat.ProxiesMediator = _ProxiesMediator;
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

    public bool LowerStamina(float decayValue) {
        /**
         * @desc Lower the player's current stamina value when the player performs an action that costs stamina 
         * @parm float $decayValue - The cost in stamina for a particular action
        */
        float tempStamina = _CurrentStamina - decayValue;
        if (tempStamina < 0.0f) {
            return false;
        } else {
            _CurrentStamina = tempStamina;
            _HudFunctionality.DecreaseStaminaBar(_CurrentStamina / _MaxStamina);
            _TimeSinceLastDecreaseInStamina = 0.0f; //Everytime the player performs an action that causes the total stamina to fall, reset the recover time for stamina
            return true;
        }

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
                    _HudFunctionality.IncreaseStaminaBar(_CurrentStamina / _MaxStamina);
                }
            }
        }
    }
}
