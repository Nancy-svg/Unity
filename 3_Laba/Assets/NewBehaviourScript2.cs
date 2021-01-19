using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    //Создаем переменную для точки назначения
    public Vector3 targetPoint;

    //Создаем переменную для обозначения скорости движения
    float _speed;
    float X, Y, Z;
    void Start()
    {
        targetPoint = new Vector3(X, Y, Z); // Указываешь нужные координаты
        _speed = 5; // указываем скорость
    }

    void FixedUpdate()
    {

        MoveObj(); // Вызываем метод для движения, вызов происходит каждый фрейм или что то вроде того
    }

    void MoveObj()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, _speed);
        //Двигаем объект с помощью метода MoveTowards, в скобках слева на право 1. Текущее положение, 2. Точка назначения, 3. скорость
    }
}
