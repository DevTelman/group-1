using UnityEngine;

public class StaticCameraFollow : MonoBehaviour
{
    public Transform target;        // Քաշիր-գցիր Player-ին այստեղ
    public Vector3 offset;          // Հեռավորությունը կերպարից (օրինակ՝ 0, 10, -10)
    public float smoothSpeed = 0.125f; // Սահունության գործակիցը

    void Start()
    {
        // Եթե offset-ը Inspector-ում չես գրել, այն ավտոմատ կվերցնի 
        // կամերայի և կերպարի սկզբնական հեռավորությունը
        if (offset == Vector3.zero && target != null)
        {
            offset = transform.position - target.position;
        }
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Հաշվարկում ենք նոր դիրքը՝ առանց հաշվի առնելու կերպարի պտույտը
        Vector3 desiredPosition = target.position + offset;

        // Սահուն տեղափոխում ենք կամերան
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // Այստեղ ՈՉ ՄԻ ՏՈՂ ՉԿԱ պտույտի (Rotation) մասին, ուստի այն կմնա անշարժ
    }
}