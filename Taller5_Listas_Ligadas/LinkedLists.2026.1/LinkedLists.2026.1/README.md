# 📚 Taller #5 — Listas Ligadas

Implementación en **C# / .NET 10** de una **lista doblemente ligada genérica** con todas las operaciones del Taller #5 del curso.

---

## 🎯 Objetivo

Demostrar el entendimiento del tema de listas ligadas implementando una **lista doblemente ligada genérica** que cumpla con las nueve operaciones definidas en el menú del taller.

---

## 🗂️ Estructura del proyecto

La solución está organizada en cuatro proyectos siguiendo el principio de separación de responsabilidades:

- **📁 Shared/** — Contratos compartidos
  - `ILinkedList.cs` — Interfaz genérica que define las operaciones

- **📁 SimpleList/** — Lista sencillamente ligada
  - `Node.cs` — Nodo con un solo puntero (Next)
  - `SinglyLinkedList.cs` — Implementación base

- **📁 DoubleList/** — Lista doblemente ligada (foco del taller)
  - `Node.cs` — Nodo con punteros Next y Previous
  - `DoubleLinkedList.cs` — Implementación completa del taller

- **📁 LinkedLists.Console/** — Aplicación de consola
  - `Program.cs` — Menú interactivo

- `LinkedLists.slnx` — Archivo de solución
- `README.md` — Este archivo

---

## ⚙️ Requisitos

- **Visual Studio 2026** (o cualquier IDE compatible con .NET 10)
- **.NET SDK 10.0** o superior
- Sistema operativo: Windows, macOS o Linux

---

## 🚀 Cómo ejecutar

### Opción 1 — Visual Studio

1. Descarga o clona este repositorio.
2. Abre el archivo `LinkedLists.slnx` con Visual Studio.
3. Haz click derecho sobre el proyecto `LinkedLists.Console` y selecciona **Establecer como proyecto de inicio**.
4. Presiona **F5** para ejecutar.

### Opción 2 — Línea de comandos

```bash
git clone https://github.com/mariacamilasanchezg9/Estructura_de_datos.git
cd Taller5_Listas_Ligadas/LinkedLists.2026.1/LinkedLists.2026.1
dotnet run --project LinkedLists.Console
```

---

## 🎮 Menú del programa

```
===== Taller #5 - Listas Ligadas =====
1. Adicionar
2. Mostrar hacia adelante
3. Mostrar hacia atrás
4. Ordenar descendentemente
5. Mostrar la(s) moda(s)
6. Mostrar gráfico
7. Existe
8. Eliminar una ocurrencia
9. Eliminar todas las ocurrencias
0. Salir
```

---

## 🔑 Operaciones implementadas

| # | Operación | Método invocado | Descripción |
|---|---|---|---|
| 1 | Adicionar | `InsertOrdered` | Inserta el elemento manteniendo el orden ascendente. Permite duplicados. |
| 2 | Mostrar adelante | `ToString` | Recorre la lista desde la cabeza hasta la cola. |
| 3 | Mostrar atrás | `ToStringReverse` | Recorre la lista desde la cola hasta la cabeza usando los punteros Previous. |
| 4 | Ordenar descendente | `Reverse` | Invierte físicamente la lista intercambiando los punteros de cada nodo. |
| 5 | Mostrar moda(s) | `GetModes` | Calcula el o los valores con mayor frecuencia. Soporta modas múltiples. |
| 6 | Mostrar gráfico | `GetGraph` | Despliega un gráfico de frecuencias con asteriscos, en orden ascendente. |
| 7 | Existe | `Contains` | Retorna true si al menos una ocurrencia del valor existe. |
| 8 | Eliminar una | `Remove` | Elimina la primera ocurrencia encontrada. |
| 9 | Eliminar todas | `RemoveAll` | Elimina todas las ocurrencias y devuelve el número eliminado. |

---

## 🧪 Ejemplos de uso

### Ejemplo 1: Con colores (strings)

Al adicionar `Blanco`, `Azul`, `Amarillo`, `Verde`, `Negro`, la lista se ordena internamente:

```
Amarillo -> Azul -> Blanco -> Negro -> Verde -> null
```

Al aplicar **Ordenar descendentemente**:

```
Verde -> Negro -> Blanco -> Azul -> Amarillo -> null
```

### Ejemplo 2: Con números

Al adicionar `1, 2, 3, 3, 2, 5, 6, 6, 6, 3, 6`:

Lista interna (ascendente):

```
1 -> 2 -> 2 -> 3 -> 3 -> 3 -> 5 -> 6 -> 6 -> 6 -> 6 -> null
```

Moda (opción 5):

```
La moda es: 6
```

Gráfico (opción 6):

```
1 *
2 **
3 ***
5 *
6 ****
```

### Ejemplo 3: Modas múltiples

Si se adicionan `1, 2, 3, 3, 2, 5, 6, 6, 6, 3` (sin el último 6):

```
Las modas son: 3, 6
```
