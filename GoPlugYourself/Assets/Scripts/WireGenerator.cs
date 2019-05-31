using UnityEngine;

public class WireGenerator : MonoBehaviour
{
    public Rigidbody2D startPoint;
    public GameObject wireSegment;
    public int length = 20;
    public PlugGenerator plug;


    void Start()
    {
        GenerateWire();    
    }


    void GenerateWire()
    {
        Rigidbody2D previous = startPoint;
        for (int i = 0; i < length; i++)
        {
            GameObject segment = Instantiate(wireSegment, transform);
            HingeJoint2D connector = segment.GetComponent<HingeJoint2D>();
            connector.connectedBody = previous;

            if (!(i < length - 1))
            {
                plug.AttachPlugToWire(segment.GetComponent<Rigidbody2D>());
            }

            previous = segment.GetComponent<Rigidbody2D>();
        }
    }

}
