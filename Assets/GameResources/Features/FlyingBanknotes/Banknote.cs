namespace Features.FlyingBanknotes
{
    using Features.Parameters;
    using UnityEngine;

    /// <summary>
    /// Поведение банкноты
    /// </summary>
    public class Banknote : MonoBehaviour
    {
        [SerializeField] private ParametersModel parametersModel = default;

        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float fallSpeed = 5f;
        [SerializeField] private float rotationSpeed = 400f;

        private Vector3 targetPosition = default;
        private bool isFalling = false;

        private void Start() => targetPosition.y = parametersModel.YBound;
        
        private void Update()
        {
            if (!isFalling)
                MoveToTarget();
            else
                FallDown();

            RotateObject();
        }

        private void MoveToTarget()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (transform.position == targetPosition)
                isFalling = true;
        }

        private void FallDown() => transform.position = new Vector3(transform.position.x, transform.position.y - fallSpeed * Time.deltaTime, transform.position.z);

        private void RotateObject() => transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        private void OnEnable()
        {
            float orthographicSize = Camera.main.orthographicSize;
            float aspect = Camera.main.aspect;
            float cameraWidthHalf = orthographicSize * aspect;

            targetPosition.x = Random.Range(-cameraWidthHalf, cameraWidthHalf);
        }
        private void OnDisable() => isFalling = false;
    }
}