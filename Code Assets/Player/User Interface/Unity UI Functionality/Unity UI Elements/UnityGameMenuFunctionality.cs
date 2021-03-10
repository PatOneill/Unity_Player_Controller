using UnityEngine;

public class UnityGameMenuFunctionality {
    private GameObject _PlayerGameMenu;

    public UnityGameMenuFunctionality(GameObject canvasObject) {
        _PlayerGameMenu = canvasObject.transform.Find("Player Game Menu").gameObject;
    }

    public void UIDisplayOn() {
        /**
          * @desc Enable the player's Game Menu display and script functionality
        */
        _PlayerGameMenu.SetActive(true);
    }

    public void UIDisplayOff() {
        /**
          * @desc Disable the player's Game Menu display and script functionality
        */
        _PlayerGameMenu.SetActive(false);
    }
}
