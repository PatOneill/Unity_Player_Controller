public class InstantHealPotion : AItem {

    public InstantHealPotion() {
        _ItemName = "Level 1 Instant Heal Potion";
        _ItemDescription = "Drinking the Potion will heal you for 10 HP";
        _ItemRarity = "Common";
        _CurrentStackAmount = 1;
        _StackableAmount = 2;
        _ItemWeight = 0.5f;
        _StackWeight = _ItemWeight * _CurrentStackAmount;
        _SellPrice = 5;
    }
}