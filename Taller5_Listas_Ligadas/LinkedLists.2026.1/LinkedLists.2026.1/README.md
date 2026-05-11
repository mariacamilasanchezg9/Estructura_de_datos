🎯 Objetivo
Demostrar el entendimiento del tema de listas ligadas implementando una lista doblemente ligada genérica que cumpla con las nueve operaciones definidas en el menú del taller.

🗂️ Estructura del proyecto
La solución está organizada en cuatro proyectos siguiendo el principio de separación de responsabilidades:
LinkedLists.2026.1/
│
├── 📁 Shared/                       ← Contratos compartidos
│   └── ILinkedList.cs               ← Interfaz genérica que define las operaciones
│
├── 📁 SimpleList/                   ← Lista sencillamente ligada
│   ├── Node.cs                      ← Nodo con un solo puntero (Next)
│   └── SinglyLinkedList.cs          ← Implementación base
│
├── 📁 DoubleList/                   ← Lista doblemente ligada (foco del taller)
│   ├── Node.cs                      ← Nodo con punteros Next y Previous
│   └── DoubleLinkedList.cs          ← Implementación completa del taller
│
├── 📁 LinkedLists.Console/          ← Aplicación de consola
│   └── Program.cs                   ← Menú interactivo
│
├── LinkedLists.slnx                 ← Archivo de solución
└── README.md                        ← Este archivo

⚙️ Requisitos

Visual Studio 2026 (o cualquier IDE compatible con .NET 10)
.NET SDK 10.0 o superior
Sistema operativo: Windows, macOS o Linux


🚀 Cómo ejecutar
Opción 1 — Visual Studio

Descarga o clona este repositorio
Abre el archivo LinkedLists.slnx con Visual Studio
Click derecho sobre el proyecto LinkedLists.Console → Establecer como proyecto de inicio
Presiona F5 para ejecutar