using UnityEngine;

public class PlugGenerator : MonoBehaviour
{
    public void AttachPlugToWire(Rigidbody2D lastSegment)
    {
        HingeJoint2D lastConnector = gameObject.GetComponent<HingeJoint2D>();
        lastConnector.autoConfigureConnectedAnchor = false;
        lastConnector.connectedBody = lastSegment;
        lastConnector.anchor = Vector2.zero;
        lastConnector.connectedAnchor = new Vector2(0.8f, 0);
    }
}
