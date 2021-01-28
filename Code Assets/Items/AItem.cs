public class AItem {
    protected string _ItemName;
    protected string _ItemDescription;
    protected string _ItemRarity;
    protected int _CurrentStackAmount;
    protected int _StackableAmount;
    protected float _ItemWeight;
    protected float _StackWeight;
    protected int _SellPrice;
    

    public string GetItemName() {
        return _ItemName;
    }

    public int GetMaxStackAmount() {
        return _StackableAmount;
    }

    public int GetCurrentStackAmount() {
        return _CurrentStackAmount;
    }

    public float GetItemWeight() {
        return _ItemWeight;
    }

    public float GetStackWeight() {
        return _StackWeight;
    }

    public void SetStackCount(int count) {
        _CurrentStackAmount = count;
        _StackWeight = count * _ItemWeight;
    }
}
