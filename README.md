# Interfaces Inteligentes P02
## Ejercicio 1: ColorChanger
```cs
public class ColorChanger : MonoBehaviour {
  private Color color;
  public int frameDelay = 120;
  private int frameCounter;
```

```cs
  void Start() {
    ChangeRandomColor();
    ApplyColor();
  }
```

```cs
  void Update() {
    frameCounter++;
    if (frameCounter >= frameDelay) {
      frameCounter = 0;
      ChangeRandomColor();
      ApplyColor();
    }
  }
```

```cs
  void ChangeRandomColor() {
    color = new Color(Random.value, Random.value, Random.value, Random.value);
  }
```

```cs
  void ApplyColor() {
    Renderer renderer = GetComponent<Renderer>();
    if (renderer != null) {
      renderer.material.color = color;
    }
  }
}
```
## Ejercicio 2
## Ejercicio 3
## Ejercicio 4
## Ejercicio 5
## Ejercicio 6
## Ejercicio 7
## Ejercicio 8
