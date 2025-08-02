# 🌐 Gestión Inteligente de Tareas - Web App

Una aplicación web moderna en ASP.NET Core para gestionar tareas de manera eficiente con una interfaz bonita y responsive.

## ✨ Características

- 🎨 **Interfaz Web Moderna**: Diseño responsive con Bootstrap 5 y gradientes
- ✅ **CRUD Completo**: Crear, leer, actualizar y eliminar tareas
- 🔍 **Búsqueda Avanzada**: Encuentra tareas por título o descripción
- 📊 **Ordenamiento**: Ordena por título, fecha, prioridad o estado
- 📈 **Dashboard**: Estadísticas en tiempo real con tarjetas coloridas
- 💾 **Persistencia**: Los datos se guardan automáticamente en JSON
- 📱 **Responsive**: Funciona perfectamente en móviles y tablets
- 🎯 **Prioridades**: Sistema de colores para prioridades (Alta, Media, Baja)

## 🚀 Cómo usar

### Requisitos
- .NET 6.0 o superior
- Visual Studio 2022 o Visual Studio Code

### Instalación

1. **Crear nuevo proyecto Web App (MVC) en Visual Studio**:
   - File → New → Project
   - Buscar "ASP.NET Core Web App (Model-View-Controller)"
   - Nombre: `TaskManager`
   - Framework: `.NET 6.0`

2. **Instalar paquete NuGet**:
   ```
   Install-Package Newtonsoft.Json
   ```

3. **Crear estructura de carpetas**:
   - Models/
   - Services/
   - Controllers/
   - Views/Home/
   - Views/Shared/

4. **Copiar todos los archivos** exactamente como están

5. **Ejecutar la aplicación**:
   ```bash
   dotnet run
   ```
   O presionar **F5** en Visual Studio

6. **Abrir en navegador**: `https://localhost:5001`

## 🎨 Características de la Interfaz

### Dashboard Principal
- **Tarjetas de estadísticas** con iconos y colores
- **Gradientes modernos** y efectos hover
- **Diseño tipo card** para cada tarea

### Funcionalidades
- **Modales** para crear y editar tareas
- **Búsqueda en tiempo real**
- **Filtros y ordenamiento**
- **Confirmaciones** para eliminar
- **Estados visuales** (completada/pendiente)
- **Colores por prioridad**

### Responsive Design
- **Mobile-first** approach
- **Grid system** de Bootstrap
- **Iconos** de Font Awesome
- **Animaciones** suaves

## 📁 Estructura del Proyecto

```
TaskManager/
├── Controllers/
│   └── HomeController.cs        # Controlador principal
├── Models/
│   └── Task.cs                  # Modelo de datos
├── Services/
│   └── TaskService.cs           # Lógica de negocio
├── Views/
│   ├── Home/
│   │   └── Index.cshtml         # Vista principal
│   ├── Shared/
│   │   └── _Layout.cshtml       # Layout principal
│   ├── _ViewStart.cshtml        # Configuración de vistas
│   └── _ViewImports.cshtml      # Imports globales
├── Program.cs                   # Configuración de la app
├── TaskManager.csproj           # Configuración del proyecto
└── README.md                    # Este archivo
```

## 🛠️ Tecnologías Utilizadas

- **ASP.NET Core 6.0**: Framework web
- **MVC Pattern**: Arquitectura Modelo-Vista-Controlador
- **Bootstrap 5**: Framework CSS
- **Font Awesome**: Iconos
- **Newtonsoft.Json**: Serialización de datos
- **HTML5/CSS3**: Estructura y estilos
- **JavaScript**: Interactividad

## 🎯 Funcionalidades Implementadas

### ✅ CRUD Completo
- Crear tareas con título, descripción y prioridad
- Ver todas las tareas en formato de tarjetas
- Editar tareas existentes con modal
- Eliminar tareas con confirmación
- Marcar como completada/pendiente

### 🔍 Búsqueda y Filtros
- Búsqueda por texto en título y descripción
- Ordenamiento por título, fecha, prioridad, estado
- Filtros combinables

### 📊 Dashboard
- Total de tareas
- Tareas completadas
- Tareas pendientes
- Tareas de alta prioridad
- Porcentaje de completado

## 🌈 Paleta de Colores

- **Primario**: #4f46e5 (Índigo)
- **Secundario**: #06b6d4 (Cyan)
- **Éxito**: #10b981 (Verde)
- **Advertencia**: #f59e0b (Amarillo)
- **Peligro**: #ef4444 (Rojo)

## 🚀 Para subir a GitHub

1. **Inicializar Git**:
   ```bash
   git init
   git add .
   git commit -m "Initial commit: Task Manager Web App"
   ```

2. **Crear repositorio en GitHub** y conectar:
   ```bash
   git remote add origin https://github.com/TU-USUARIO/TaskManager.git
   git branch -M main
   git push -u origin main
   ```

## 📱 Screenshots

La aplicación incluye:
- Dashboard con estadísticas coloridas
- Lista de tareas en formato de tarjetas
- Modales para crear/editar tareas
- Búsqueda y filtros avanzados
- Diseño completamente responsive

---

¡Disfruta gestionando tus tareas con esta moderna aplicación web! 🎉