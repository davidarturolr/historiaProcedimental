using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class escena : MonoBehaviour
{
    public float speed = 1.0f;

    

    UnityEvent m_MyEvent = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
      

        //pasto del parque
        GameObject plano = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plano.GetComponent<Renderer>().material.color = Color.green;
        plano.transform.position = new Vector3(0, -1, 0);
        plano.transform.eulerAngles = new Vector3(0, 0, 0);
        plano.transform.localScale = new Vector3(5, 1, 5);

        //edificios
        GameObject edf1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        edf1.GetComponent<Renderer>().material.color = Color.cyan;
        edf1.transform.position = new Vector3(24.81f, 8, 0);
        edf1.transform.eulerAngles = new Vector3(0, 0, 0);
        edf1.transform.localScale = new Vector3(10, 20, 10);
        edf1.transform.parent = plano.transform;

        GameObject edf2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        edf2.GetComponent<Renderer>().material.color = Color.cyan;
        edf2.transform.position = new Vector3(24.81f, 8, 15);
        edf2.transform.eulerAngles = new Vector3(0, 0, 0);
        edf2.transform.localScale = new Vector3(10, 20, 10);
        edf2.transform.parent = plano.transform;

        GameObject edf3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        edf3.GetComponent<Renderer>().material.color = Color.cyan;
        edf3.transform.position = new Vector3(24.81f, 8, -13);
        edf3.transform.eulerAngles = new Vector3(0, 0, 0);
        edf3.transform.localScale = new Vector3(10, 20, 10);
        edf3.transform.parent = plano.transform;

        //acera 
        GameObject anden = GameObject.CreatePrimitive(PrimitiveType.Plane);
        anden.GetComponent<Renderer>().material.color = Color.white;
        anden.transform.position = new Vector3(0, -1, 30);
        anden.transform.eulerAngles = new Vector3(0, 0, 0);
        anden.transform.localScale = new Vector3(5, 1, 1);

        //carretera 
        GameObject carretera= GameObject.CreatePrimitive(PrimitiveType.Plane);
        carretera.GetComponent<Renderer>().material.color = Color.white;
        carretera.transform.position = new Vector3(0, -1, 45);
        carretera.transform.eulerAngles = new Vector3(0, 0, 0);
        carretera.transform.localScale = new Vector3(15, 1, 2);
        carretera.GetComponent<Renderer>().material.color = Color.black;

        //bicicleta
        GameObject llanta1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        llanta1.transform.position = new Vector3(-0, -0.5f, 22);
        llanta1.transform.eulerAngles = new Vector3(90, 0, 0);
        llanta1.transform.localScale = new Vector3(1, 0.1f, 1);
        llanta1.GetComponent<Renderer>().material.color = Color.black;
        

        GameObject llanta2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        llanta2.transform.position = new Vector3(2, -0.5f, 22);
        llanta2.transform.eulerAngles = new Vector3(90, 0, 0);
        llanta2.transform.localScale = new Vector3(1, 0.1f, 1);
        llanta2.GetComponent<Renderer>().material.color = Color.black;
        llanta2.transform.parent = llanta1.transform;

        GameObject marcoDown = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        marcoDown.transform.position = new Vector3(1, -0.5f, 22);
        marcoDown.transform.eulerAngles = new Vector3(0, 0, 110);
        marcoDown.transform.localScale = new Vector3(0.1f, 1, 0.2f);
        marcoDown.GetComponent<Renderer>().material.color = Color.red;
        marcoDown.transform.parent = llanta1.transform;

        GameObject marcoUp = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        marcoUp.transform.position = new Vector3(1, -0.2f, 22);
        marcoUp.transform.eulerAngles = new Vector3(0, 0, 90);
        marcoUp.transform.localScale = new Vector3(0.1f, 1, 0.2f);
        marcoUp.GetComponent<Renderer>().material.color = Color.red;
        marcoUp.transform.parent = llanta1.transform;

        GameObject manubrio = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        manubrio.transform.position = new Vector3(1.7f, 0.2f, 22);
        manubrio.transform.eulerAngles = new Vector3(90, 0, 0);
        manubrio.transform.localScale = new Vector3(0.1f, 1, 0.1f);
        manubrio.GetComponent<Renderer>().material.color = Color.blue;
        manubrio.transform.parent = llanta1.transform;

        GameObject tubo1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tubo1.transform.position = new Vector3(1.7f, 0, 22);
        tubo1.transform.eulerAngles = new Vector3(0, 90, 0);
        tubo1.transform.localScale = new Vector3(0.1f, 0.16f, 0.1f);
        tubo1.GetComponent<Renderer>().material.color = Color.red;
        tubo1.transform.parent = llanta1.transform;

        GameObject tubo2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tubo2.transform.position = new Vector3(0.5f, -0.4f, 22);
        tubo2.transform.eulerAngles = new Vector3(0, 0, 0);
        tubo2.transform.localScale = new Vector3(0.1f, 0.24f, 0.1f);
        tubo2.GetComponent<Renderer>().material.color = Color.red;
        tubo2.transform.parent = llanta1.transform;

        //persona1

        GameObject cabeza = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cabeza.transform.position = new Vector3(0.28f, 2.564f, 19);
        cabeza.transform.eulerAngles = new Vector3(0, 0, 0);
        cabeza.transform.localScale = new Vector3(1, 1, 1);
        cabeza.GetComponent<Renderer>().material.color = Color.yellow;
        

        GameObject piernaI = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        piernaI.transform.position = new Vector3(0, -0.5f, 19);
        piernaI.transform.eulerAngles = new Vector3(0, 0, 0);
        piernaI.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        piernaI.GetComponent<Renderer>().material.color = Color.blue;
        piernaI.transform.parent = cabeza.transform;

        GameObject piernaD = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        piernaD.transform.position = new Vector3(0.5f, -0.5f, 19);
        piernaD.transform.eulerAngles = new Vector3(0, 0, 0);
        piernaD.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        piernaD.GetComponent<Renderer>().material.color = Color.blue;
        piernaD.transform.parent = cabeza.transform;


        GameObject cuerpo = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cuerpo.transform.position = new Vector3(0.27f, 0.97f, 19);
        cuerpo.transform.eulerAngles = new Vector3(0, 0, 0);
        cuerpo.transform.localScale = new Vector3(1, 1, 1);
        cuerpo.GetComponent<Renderer>().material.color = Color.blue;
        cuerpo.transform.parent = cabeza.transform;


        GameObject cuello = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cuello.transform.position = new Vector3(0.281f, 2.048f, 19);
        cuello.transform.eulerAngles = new Vector3(0, 0, 0);
        cuello.transform.localScale = new Vector3(0.3f, 0.1f, 1);
        cuello.GetComponent<Renderer>().material.color = Color.yellow;
        cuello.transform.parent = cabeza.transform;

        GameObject brazoI = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoI.transform.position = new Vector3(-0.57f, 1.39f, 19);
        brazoI.transform.eulerAngles = new Vector3(0, 0, 135);
        brazoI.transform.localScale = new Vector3(0.3f, 0.6f, 0.3f);
        brazoI.GetComponent<Renderer>().material.color = Color.blue;
        brazoI.transform.parent = cabeza.transform;

        GameObject brazoD = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoD.transform.position = new Vector3(1.076f, 1.438f, 19);
        brazoD.transform.eulerAngles = new Vector3(0, 0, 45);
        brazoD.transform.localScale = new Vector3(0.3f, 0.6f, 0.3f);
        brazoD.GetComponent<Renderer>().material.color = Color.blue;
        brazoD.transform.parent = cabeza.transform;

        //persona2

        GameObject cabeza2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cabeza2.transform.position = new Vector3(0.28f, 2.564f, 19);
        cabeza2.transform.eulerAngles = new Vector3(0, 0, 0);
        cabeza2.transform.localScale = new Vector3(1, 1, 1);
        cabeza2.GetComponent<Renderer>().material.color = Color.yellow;


        GameObject piernaI2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        piernaI2.transform.position = new Vector3(0, -0.5f, 19);
        piernaI2.transform.eulerAngles = new Vector3(0, 0, 0);
        piernaI2.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        piernaI2.GetComponent<Renderer>().material.color = Color.red;
        piernaI2.transform.parent = cabeza2.transform;

        GameObject piernaD2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        piernaD2.transform.position = new Vector3(0.5f, -0.5f, 19);
        piernaD2.transform.eulerAngles = new Vector3(0, 0, 0);
        piernaD2.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        piernaD2.GetComponent<Renderer>().material.color = Color.red;
        piernaD2.transform.parent = cabeza2.transform;


        GameObject cuerpo2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cuerpo2.transform.position = new Vector3(0.27f, 0.97f, 19);
        cuerpo2.transform.eulerAngles = new Vector3(0, 0, 0);
        cuerpo2.transform.localScale = new Vector3(1, 1, 1);
        cuerpo2.GetComponent<Renderer>().material.color = Color.red;
        cuerpo2.transform.parent = cabeza2.transform;


        GameObject cuello2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cuello2.transform.position = new Vector3(0.281f, 2.048f, 19);
        cuello2.transform.eulerAngles = new Vector3(0, 0, 0);
        cuello2.transform.localScale = new Vector3(0.3f, 0.1f, 1);
        cuello2.GetComponent<Renderer>().material.color = Color.yellow;
        cuello2.transform.parent = cabeza2.transform;

        GameObject brazoI2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoI2.transform.position = new Vector3(-0.57f, 1.39f, 19);
        brazoI2.transform.eulerAngles = new Vector3(0, 0, 135);
        brazoI2.transform.localScale = new Vector3(0.3f, 0.6f, 0.3f);
        brazoI2.GetComponent<Renderer>().material.color = Color.red;
        brazoI2.transform.parent = cabeza2.transform;

        GameObject brazoD2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoD2.transform.position = new Vector3(1.076f, 1.438f, 19);
        brazoD2.transform.eulerAngles = new Vector3(0, 0, 45);
        brazoD2.transform.localScale = new Vector3(0.3f, 0.6f, 0.3f);
        brazoD2.GetComponent<Renderer>().material.color = Color.red;
        brazoD2.transform.parent = cabeza2.transform;

        cabeza2.transform.position = new Vector3(4.28f, 2.564f, 10);


        //persona3

        GameObject cabeza3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cabeza3.transform.position = new Vector3(0.28f, 2.564f, 19);
        cabeza3.transform.eulerAngles = new Vector3(0, 0, 0);
        cabeza3.transform.localScale = new Vector3(1, 1, 1);
        cabeza3.GetComponent<Renderer>().material.color = Color.yellow;


        GameObject piernaI3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        piernaI3.transform.position = new Vector3(0, -0.5f, 19);
        piernaI3.transform.eulerAngles = new Vector3(0, 0, 0);
        piernaI3.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        piernaI3.GetComponent<Renderer>().material.color = Color.blue;
        piernaI3.transform.parent = cabeza3.transform;

        GameObject piernaD3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        piernaD3.transform.position = new Vector3(0.5f, -0.5f, 19);
        piernaD3.transform.eulerAngles = new Vector3(0, 0, 0);
        piernaD3.transform.localScale = new Vector3(0.3f, 0.5f, 0.3f);
        piernaD3.GetComponent<Renderer>().material.color = Color.blue;
        piernaD3.transform.parent = cabeza3.transform;


        GameObject cuerpo3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cuerpo3.transform.position = new Vector3(0.27f, 0.97f, 19);
        cuerpo3.transform.eulerAngles = new Vector3(0, 0, 0);
        cuerpo3.transform.localScale = new Vector3(1, 1, 1);
        cuerpo3.GetComponent<Renderer>().material.color = Color.blue;
        cuerpo3.transform.parent = cabeza3.transform;


        GameObject cuello3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cuello3.transform.position = new Vector3(0.281f, 2.048f, 19);
        cuello3.transform.eulerAngles = new Vector3(0, 0, 0);
        cuello3.transform.localScale = new Vector3(0.3f, 0.1f, 1);
        cuello3.GetComponent<Renderer>().material.color = Color.yellow;
        cuello3.transform.parent = cabeza3.transform;

        GameObject brazoI3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoI3.transform.position = new Vector3(-0.57f, 1.39f, 19);
        brazoI3.transform.eulerAngles = new Vector3(0, 0, 135);
        brazoI3.transform.localScale = new Vector3(0.3f, 0.6f, 0.3f);
        brazoI3.GetComponent<Renderer>().material.color = Color.blue;
        brazoI3.transform.parent = cabeza3.transform;

        GameObject brazoD3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoD3.transform.position = new Vector3(1.076f, 1.438f, 19);
        brazoD3.transform.eulerAngles = new Vector3(0, 0, 45);
        brazoD3.transform.localScale = new Vector3(0.3f, 0.6f, 0.3f);
        brazoD3.GetComponent<Renderer>().material.color = Color.blue;
        brazoD3.transform.parent = cabeza3.transform;

        cabeza3.transform.position = new Vector3(-10.28f, 2.564f, -10);



        //bancas


        GameObject silla = GameObject.CreatePrimitive(PrimitiveType.Cube);
        silla.transform.position = new Vector3(3.448536f, 0.50f, 29.78f);
        silla.transform.eulerAngles = new Vector3(0, 0, 0);
        silla.transform.localScale = new Vector3(4, 0.5f, 2);
        silla.GetComponent<Renderer>().material.color = Color.white;


        GameObject p1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p1.transform.position = new Vector3(1.73f, -0.5f, 29);
        p1.transform.eulerAngles = new Vector3(0, 0, 0);
        p1.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p1.GetComponent<Renderer>().material.color = Color.white;
        p1.transform.parent = silla.transform;

        GameObject p2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p2.transform.position = new Vector3(5.2f, -0.5f, 29);
        p2.transform.eulerAngles = new Vector3(0, 0, 0);
        p2.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p2.GetComponent<Renderer>().material.color = Color.white;
        p2.transform.parent = silla.transform;

        GameObject p3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p3.transform.position = new Vector3(1.92f, -0.5f, 30.5f);
        p3.transform.eulerAngles = new Vector3(0, 0, 0);
        p3.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p3.GetComponent<Renderer>().material.color = Color.white;
        p3.transform.parent = silla.transform;

        GameObject p4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p4.transform.position = new Vector3(5.2f, -0.5f, 30.5f);
        p4.transform.eulerAngles = new Vector3(0, 0, 0);
        p4.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p4.GetComponent<Renderer>().material.color = Color.white;
        p4.transform.parent = silla.transform;

        GameObject espaldar = GameObject.CreatePrimitive(PrimitiveType.Cube);
        espaldar.transform.position = new Vector3(3.5f, 1.37f, 28.67f);
        espaldar.transform.eulerAngles = new Vector3(0, 0, 0);
        espaldar.transform.localScale = new Vector3(4, 1.5f, 0.5f);
        espaldar.GetComponent<Renderer>().material.color = Color.white;
        espaldar.transform.parent = silla.transform;
        silla.transform.position = new Vector3(-6.54f, 0.5f, 27.4f);

        GameObject silla2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        silla2.transform.position = new Vector3(3.448536f, 0.50f, 29.78f);
        silla2.transform.eulerAngles = new Vector3(0, 0, 0);
        silla2.transform.localScale = new Vector3(4, 0.5f, 2);
        silla2.GetComponent<Renderer>().material.color = Color.white;


        GameObject p12 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p12.transform.position = new Vector3(1.73f, -0.5f, 29);
        p12.transform.eulerAngles = new Vector3(0, 0, 0);
        p12.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p12.GetComponent<Renderer>().material.color = Color.white;
        p12.transform.parent = silla2.transform;

        GameObject p22 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p22.transform.position = new Vector3(5.2f, -0.5f, 29);
        p22.transform.eulerAngles = new Vector3(0, 0, 0);
        p22.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p22.GetComponent<Renderer>().material.color = Color.white;
        p22.transform.parent = silla2.transform;

        GameObject p32 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p32.transform.position = new Vector3(1.92f, -0.5f, 30.5f);
        p32.transform.eulerAngles = new Vector3(0, 0, 0);
        p32.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p32.GetComponent<Renderer>().material.color = Color.white;
        p32.transform.parent = silla2.transform;

        GameObject p42 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        p42.transform.position = new Vector3(5.2f, -0.5f, 30.5f);
        p42.transform.eulerAngles = new Vector3(0, 0, 0);
        p42.transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        p42.GetComponent<Renderer>().material.color = Color.white;
        p42.transform.parent = silla2.transform;

        GameObject espaldar2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        espaldar2.transform.position = new Vector3(3.5f, 1.37f, 28.67f);
        espaldar2.transform.eulerAngles = new Vector3(0, 0, 0);
        espaldar2.transform.localScale = new Vector3(4, 1.5f, 0.5f);
        espaldar2.GetComponent<Renderer>().material.color = Color.white;
        espaldar2.transform.parent = silla2.transform;
        silla2.transform.position = new Vector3(6.54f, 0.5f, 27.4f);

        //arboles

        GameObject tronco1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco1.transform.position = new Vector3(14.78948f, 0.5f, -23.25451f);
        tronco1.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco1.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas.transform.localScale = new Vector3(5, 5, 5);
        hojas.GetComponent<Renderer>().material.color = Color.green;
        hojas.transform.parent = tronco1.transform;

        GameObject tronco2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco2.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco2.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco2.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas2.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas2.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas2.transform.localScale = new Vector3(5, 5, 5);
        hojas2.GetComponent<Renderer>().material.color = Color.green;
        hojas2.transform.parent = tronco2.transform;
        tronco2.transform.position = new Vector3(-14.78948f, 0.5f, -23.25451f);

        GameObject tronco3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco3.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco3.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco3.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas3.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas3.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas3.transform.localScale = new Vector3(5, 5, 5);
        hojas3.GetComponent<Renderer>().material.color = Color.green;
        hojas3.transform.parent = tronco3.transform;
        tronco3.transform.position = new Vector3(14.78948f, 0.5f, -13.25451f);


        GameObject tronco4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco4.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco4.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco4.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas4 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas4.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas4.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas4.transform.localScale = new Vector3(5, 5, 5);
        hojas4.GetComponent<Renderer>().material.color = Color.green;
        hojas4.transform.parent = tronco4.transform;
        tronco4.transform.position = new Vector3(-14.78948f, 0.5f, -13.25451f);

        GameObject tronco5 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco5.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco5.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco5.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas5 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas5.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas5.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas5.transform.localScale = new Vector3(5, 5, 5);
        hojas5.GetComponent<Renderer>().material.color = Color.green;
        hojas5.transform.parent = tronco5.transform;
        tronco5.transform.position = new Vector3(14.78948f, 0.5f, -5.25451f);

        GameObject tronco6 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco6.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco6.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco6.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas6 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas6.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas6.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas6.transform.localScale = new Vector3(5, 5, 5);
        hojas6.GetComponent<Renderer>().material.color = Color.green;
        hojas6.transform.parent = tronco6.transform;
        tronco6.transform.position = new Vector3(-14.78948f, 0.5f, -5.25451f);

        GameObject tronco7 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco7.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco7.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco7.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas7 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas7.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas7.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas7.transform.localScale = new Vector3(5, 5, 5);
        hojas7.GetComponent<Renderer>().material.color = Color.green;
        hojas7.transform.parent = tronco7.transform;
        tronco7.transform.position = new Vector3(14.78948f, -0.5f , 8.25451f);


        GameObject tronco8 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        tronco8.transform.position = new Vector3(14.78948f, -0.7734f, -23.25451f);
        tronco8.transform.eulerAngles = new Vector3(0, 0, 0);
        tronco8.transform.localScale = new Vector3(0.5f, 2, 0.5f);

        GameObject hojas8 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hojas8.transform.position = new Vector3(14.69f, 3.07f, -23.02f);
        hojas8.transform.eulerAngles = new Vector3(0, 0, 0);
        hojas8.transform.localScale = new Vector3(5, 5, 5);
        hojas8.GetComponent<Renderer>().material.color = Color.green;
        hojas8.transform.parent = tronco8.transform;
        tronco8.transform.position = new Vector3(-14.78948f, 0.5f, 8.25451f);

        GameObject aCentral = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        aCentral.transform.position = new Vector3(14.78948f, 1.7f, -23.25451f);
        aCentral.transform.eulerAngles = new Vector3(0, 0, 0);
        aCentral.transform.localScale = new Vector3(0.5f, 7, 0.5f);

        GameObject hCentral = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hCentral.transform.position = new Vector3(14.69f, 6.07f, -23.02f);
        hCentral.transform.eulerAngles = new Vector3(0, 0, 0);
        hCentral.transform.localScale = new Vector3(10, 10, 10);
        hCentral.GetComponent<Renderer>().material.color = Color.green;
        hCentral.transform.parent = aCentral.transform;
        GameObject hCentralC = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hCentralC.transform.position = new Vector3(14.69f, 6.07f, -23.02f);
        hCentralC.transform.eulerAngles = new Vector3(0, 0, 0);
        hCentralC.transform.localScale = new Vector3(7, 7, 7);
        hCentralC.GetComponent<Renderer>().material.color = Color.green;
        hCentralC.transform.parent = aCentral.transform;
        GameObject hCentralCo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hCentralCo.transform.position = new Vector3(14.69f, 6.07f, -23.02f);
        hCentralCo.transform.eulerAngles = new Vector3(0, 45, 0);
        hCentralCo.transform.localScale = new Vector3(7.5f, 7.5f, 7.5f);
        hCentralCo.GetComponent<Renderer>().material.color = Color.green;
        hCentralCo.transform.parent = aCentral.transform;
        aCentral.transform.position = new Vector3(-1.68f, 6, 0);


        //poste de luz
        GameObject poste1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        poste1.transform.position = new Vector3(19.95271f, -7, 12.5f);
        poste1.transform.eulerAngles = new Vector3(0, 0, 0);
        poste1.transform.localScale = new Vector3(0.3f, 8, 0.3f);

        GameObject luz1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        luz1.transform.position = new Vector3(20.14f, 0.53f, 11.9f);
        luz1.transform.eulerAngles = new Vector3(0, 0, 0);
        luz1.transform.localScale = new Vector3(1, 1, 1);
        luz1.GetComponent<Renderer>().material.color = Color.yellow;
        luz1.transform.parent = poste1.transform;
        poste1.transform.position = new Vector3(-1.68f, 6.82f, 26.73f);


        //caneca
        GameObject base1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        base1.transform.position = new Vector3(19.95271f, -7, 12.5f);
        base1.transform.eulerAngles = new Vector3(0, 0, 0);
        base1.transform.localScale = new Vector3(0.1f, 1, 0.1f);

        GameObject caneca = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        caneca.transform.position = new Vector3(19.95271f, -6.8f, 12.5f);
        caneca.transform.eulerAngles = new Vector3(0, 0, 0);
        caneca.transform.localScale = new Vector3(1, 1, 1);
        caneca.GetComponent<Renderer>().material.color = Color.white;
        caneca.transform.parent = base1.transform;
        base1.transform.position = new Vector3(0.28f, 0, 10);


        GameObject base2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        base2.transform.position = new Vector3(19.95271f, -7, 12.5f);
        base2.transform.eulerAngles = new Vector3(0, 0, 0);
        base2.transform.localScale = new Vector3(0.1f, 1, 0.1f);

        GameObject caneca2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        caneca2.transform.position = new Vector3(19.95271f, -6.8f, 12.5f);
        caneca2.transform.eulerAngles = new Vector3(0, 0, 0);
        caneca2.transform.localScale = new Vector3(1, 1, 1);
        caneca2.GetComponent<Renderer>().material.color = Color.white;
        caneca2.transform.parent = base2.transform;
        base2.transform.position = new Vector3(0.28f, 0, -10);

    

    }
  


    // Update is called once per frame
    void Update()
    {

    }

   
}
