# <p align="center"> Tanks 2D Demo</p>

<div align="Center">
    <img src = https://github.com/iFEL1x/iFEL1x/blob/main/Resources/Screenshots/Screen(Tank%202D)(0).png>
</div>


## Описание проекта

Данный проект является моим обучением на курсе
***"Unity Углублённый курс по C#"*** онлайн школы Unity3DSchool.com
Проект собран в Unity3D с использованием языка программирование C# и принципов ООП

В проекте используются несколько типов танков-врагов, управляемые
скриптом, в построение которых используется наследование абстрактных классов.
Каждый тип танка хранится в пуле объектов и активируется на случайной точке возрождения,
тип возрожденного танка, зависит от случайного числа суммы массива класса танков и суммы
набранного очков игроком. Так же пул содержит ядра танка игрока, чтобы исключить создание
объекта во время игры, тем самым оптимизирую проект

___
## Скачивание и установка
Для того что бы запустить проект на своем ПК

* [Скачайте](https://unity3d.com/ru/get-unity/download) и [установите](https://docs.unity3d.com/2018.2/Documentation/Manual/InstallingUnity.html) Unity3D последней версии с официального сайта.
* Скачайте проект по [ссылке](https://github.com/iFEL1x/Platformer2D_Android_Demo_Level/archive/refs/heads/main.zip) или с текущей странице "Code\Download ZIP".
    + Распакуйте архив на своем ПК.
* Запустите Unity3D
    + Рядом с кнопкой "Open" нажмите на стрелочку :arrow_down_small:, в открывшимся списке выберете "Add project from disk"
    + Выберете путь распаковки проекта, нажмите "Add Project"

___
## В данном проекте применяется
* Абстрактные классы, наследование и паттерны проектирования
* Массивы, списки, очереди с циклами.
* Построение всего проекта максимально подводилось под ООП.

*Демонсрация кода:*

```C#
public abstract class Tank : MonoBehaviour
{
...
  protected virtual void Move()
    {
        transform.Translate(Vector2.down * _movementSpeed * Time.deltaTime);
    }
...
```

```C#
public class Player : Tank
{
...
protected override void Move()
    {
        transform.Translate(Vector2.down * Input.GetAxis("Vertical") * _movementSpeed * Time.deltaTime);
    }
...
```

**Основная задача проекта** - Углубленное изучение языка программирования С#, принципов ООП и паттернов проектирования.

*Демонстрация финальной части игрового процесса:*

![PLATFORMER 2D](https://github.com/iFEL1x/iFEL1x/blob/main/Resources/Image/Gif/mp4%20to%20GIF(Tank%202D).gif)
