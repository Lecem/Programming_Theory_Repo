using TMPro;
using UnityEngine;

// INHERTIANCE
public class PowerUp : MonoBehaviour
{
    protected BoxManager _boxManager;
    public int Amount { get; protected set; }
    public TMP_Text amountText;

    private void Start()
    {
        amountText.text = Amount.ToString();
        _boxManager = FindFirstObjectByType<BoxManager>();
    }

    protected virtual void Execute() { }

    // ABSTRACTION
    public virtual void TryExecute()
    {
        if (Amount > 0)
        {
            Execute();
            Amount--;
            amountText.text = Amount.ToString();
        }
    }

    public void AddPowerUp() => Amount += 1;
}
