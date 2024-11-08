namespace Features.Utils
{
    using UnityEngine;

    /// <summary>
    /// Disable �������, ���� ��� ������� �� ������� ������
    /// </summary>
    public class OutOfCameraDisable : MonoBehaviour
    {
        private Renderer objRenderer;

        private void Start() => objRenderer = GetComponent<Renderer>();

        private void Update()
        {
            if (IsObjectOutOfBounds())
            {
                gameObject.SetActive(false);
            }
        }

        private bool IsObjectOutOfBounds()
        {
            if (objRenderer.isVisible)
            {
                return false;
            }

            return true;
        }
    }
}