namespace Features.Utils
{
    using UnityEngine.UI;
    using UnityEngine;

    /// <summary>
    /// Класс абстрактной кнопки
    /// </summary>
    [RequireComponent(typeof(Button))]
    public abstract class AbstractButton : MonoBehaviour
    {
        public Button ButtonInstance => button;

        public bool A { get; set; }

        protected Button button = default;

        protected virtual void Awake()
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(OnButtonClicked);
        }

        protected virtual void OnDestroy() => button.onClick.RemoveListener(OnButtonClicked);

        /// <summary>
        /// Нажатие на кнопку
        /// </summary>
        protected abstract void OnButtonClicked();
    }
}
