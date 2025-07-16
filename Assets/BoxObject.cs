using UnityEngine;

public class BoxObject : MonoBehaviour
{
    private ColorData _colorData;
    private MaterialPropertyBlock _propertyBlock;
    private MeshRenderer _meshRenderer;
    private BoxManager _boxManager;
    private ScoreManager _scoreManager;

    private void Awake()
    {
        _boxManager = FindFirstObjectByType<BoxManager>();
        _scoreManager = FindFirstObjectByType<ScoreManager>();
        _propertyBlock = new MaterialPropertyBlock();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void InitializeBox(ColorData colorData)
    {
        _colorData = colorData;
        UpdateColor();
    }

    private void OnMouseDown()
    {
        Debug.Log(_colorData.colorID + " " + _boxManager.CurrentColorID);
        if (_colorData.colorID == _boxManager.CurrentColorID)
        {
            _scoreManager.AddScore();
            _boxManager.boxes.Remove(this);
            Destroy(gameObject);
        }
    }

    private void UpdateColor()
    {
        _meshRenderer.GetPropertyBlock(_propertyBlock);
        _propertyBlock.SetColor("_BaseColor", _colorData.color);
        _meshRenderer.SetPropertyBlock(_propertyBlock);
    }
}
