namespace Features.Utils
{
    using UnityEngine;

    /// <summary>
    /// ����� � �������� ������������
    /// </summary>
    public static class GameObjectExtensions
    {
        /// <summary>
        /// �������� ��������� ������� � ����
        /// </summary>
        /// <param name="target"></param>
        /// <param name="parent"></param>
        public static void ResetLocalPosition(this GameObject target, GameObject parent)
        {
            target.transform.SetParent(parent.transform);
            target.transform.localPosition = Vector3.zero;
            target.transform.SetParent(null);
        }
    }
}
