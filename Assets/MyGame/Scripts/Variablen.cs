using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    Color farbe;
   
    int anzTueren;
    int anzTueren2;
    int anzTueren3;

    bool fahren;
    string name;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + "" + Himmelsrichtungen.Sued + "" + Himmelsrichtungen.West + "" + Himmelsrichtungen.Ost);

        //Anwendungsbeispiel Nr. 1
        name = "HTL Salzburg";
        Debug.Log("Hallo " + name);

        //Anwendungsbeispiel Nr. 2
        anzTueren = 3;
        anzTueren2 = 8;
        anzTueren3 = 5;
        Debug.Log(anzTueren + anzTueren2 + anzTueren3);

        //Anwendungsbeispiel Nr. 3
        farbe = Color.red;
        gameObject.GetComponent<Renderer>().material.color = farbe;

    }
}
